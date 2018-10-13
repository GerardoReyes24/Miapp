
namespace Miapp2.Northwind.Endpoints
{
    using Serenity.Data;
    using Serenity.Reporting;
    using Serenity.Services;
    using Serenity.Web;
    using System;
    using System.Data;
    using Microsoft.AspNetCore.Mvc;
    using MyRepository = Repositories.ProductRepository;
    using MyRow = Entities.ProductRow;
    using Miapp2.Northwind.Entities;
    using Miapp2.Northwind.Repositories;
    using Serenity;
    using OfficeOpenXml;
    using System.IO;
    using System.Collections.Generic;

    [Route("Services/Northwind/Product/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ProductController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
                        {
            return new MyRepository().Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public FileContentResult ListExcel(IDbConnection connection, ListRequest request)
        {
            var data = List(connection, request).Entities;
            var report = new DynamicDataReport(data, request.IncludeColumns, typeof(Columns.ProductColumns));
            var bytes = new ReportRepository().Render(report);
            return ExcelContentResult.Create(bytes, "ProductList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
        }



        [HttpPost]
        public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request)
        {
            request.CheckNotNull();
            Check.NotNullOrWhiteSpace(request.FileName, "filename");

            UploadHelper.CheckFileNameSecurity(request.FileName);

            if (!request.FileName.StartsWith("temporary/"))
                throw new ArgumentOutOfRangeException("filename");

            ExcelPackage ep = new ExcelPackage();
            using (var fs = new FileStream(UploadHelper.DbFilePath(request.FileName), FileMode.Open, FileAccess.Read))
                ep.Load(fs);

            var p = ProductRow.Fields;
            var s = SupplierRow.Fields;
            var c = CategoryRow.Fields;

            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                try
                {
                    //  var product = uow.Connection.TryFirst < ProductRow >(q => q.Select(p.ProductID)
                    //    .Where(p.ProductName == productName));
                    //      var  product = new ProductRow
                    //  {

                    //  };





                    var product = new ProductRow();
                     
              

                    var supplierName = Convert.ToString(worksheet.Cells[row, 4].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(supplierName))
                    {
                        var supplier = uow.Connection.TryFirst<SupplierRow>(q => q
                            .Select(s.SupplierID)
                            .Where(s.CompanyName == supplierName));

                        if (supplier == null)
                        {

                            var suppliernew = new SupplierRow();
                            suppliernew.CompanyName = supplierName;

                            new SupplierRepository().Create(uow, new SaveRequest<SupplierRow>
                            {

                                Entity = suppliernew,


                            });
                            //  product.CategoryID = categorynew.CategoryID.Value;
                            var suppl = uow.Connection.TryFirst<SupplierRow>(q => q
                              .Select(s.SupplierID)
                              .Where(s.CompanyName == suppliernew.CompanyName));

                            product.SupplierID = supplier.SupplierID.Value;
                        }

                        product.SupplierID = supplier.SupplierID.Value;
                    }
                    else
                        product.SupplierID = null;

                    var categoryName = Convert.ToString(worksheet.Cells[row, 5].Value ?? "");
                    if (!string.IsNullOrWhiteSpace(categoryName))
                    {
                        var category = uow.Connection.TryFirst<CategoryRow>(q => q
                            .Select(c.CategoryID)
                            .Where(c.CategoryName == categoryName));

                        if (category == null)
                        {

                            var categorynew = new CategoryRow();
                            categorynew.CategoryName = categoryName;

                            new CategoryRepository().Create(uow, new SaveRequest<CategoryRow>
                            {

                                Entity = categorynew,


                            });
                            //  product.CategoryID = categorynew.CategoryID.Value;
                            var categoryy = uow.Connection.TryFirst<CategoryRow>(q => q
                              .Select(c.CategoryID)
                              .Where(c.CategoryName == categorynew.CategoryName));

                            product.CategoryID = categoryy.CategoryID.Value;

                        }
                        else
                        {

                            product.CategoryID = category.CategoryID.Value;
                        }
                    }
                    else
                        product.CategoryID = null;





                    product.ProductName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "");
                    product.UnitPrice = Convert.ToDecimal(worksheet.Cells[row, 6].Value ?? 0);
                    product.UnitsInStock = Convert.ToInt16(worksheet.Cells[row, 7].Value ?? 0);
                    product.Product2ID = Convert.ToString(worksheet.Cells[row, 2].Value ?? "");
                    product.ProductID = Convert.ToString(worksheet.Cells[row, 1].Value ?? "");


                    var producto = uow.Connection.TryFirst<ProductRow>(q => q
                     .Select(p.ProductID)
                     .Where(p.ProductID == product.ProductID));

                    if (producto == null)
                    {
                        new ProductRepository().Create(uow, new SaveRequest<MyRow>
                        {
                            Entity = product,
                            
                        });

                        response.Inserted = response.Inserted + 1;
                    }
                    else
                    {
                        new ProductRepository().Update(uow, new SaveRequest<MyRow>
                        {
                            Entity = product,
                            EntityId = product.ProductID
                        });

                        response.Updated = response.Updated + 1;
                    }
                }
                catch (Exception ex)
                {
                    response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                }
            }

            return response;
        }
    }
}