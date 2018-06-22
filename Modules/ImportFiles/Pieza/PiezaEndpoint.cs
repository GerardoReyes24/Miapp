
namespace Miapp2.ImportFiles.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using Microsoft.AspNetCore.Mvc;
    using MyRepository = Repositories.PiezaRepository;
    using MyRow = Entities.PiezaRow;
    using Serenity.Web;
    using System;
    using OfficeOpenXml;
    using System.IO;
    using Miapp2.ImportFiles.Entities;
    using System.Collections.Generic;
    using Miapp2.ImportFiles.Repositories;
    using Serenity.Reporting;

    [Route("Services/ImportFiles/Pieza/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class PiezaController : ServiceEndpoint
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

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }



        public string resultt(IDbConnection connection)
        {
            var query = new SqlQuery();

            query.From("pza");
            query.Select("pieza");

            return query.ToString();

        }


        public FileContentResult ListExcel(IDbConnection connection, ListRequest request)
        {
            var data = List(connection, request).Entities;
            var report = new DynamicDataReport(data, request.IncludeColumns, typeof(Columns.PiezaColumns));
            var bytes = new ReportRepository().Render(report);
            return ExcelContentResult.Create(bytes, "Pieza_" +
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

            var p = PiezaRow.Fields;


            var response = new ExcelImportResponse();
            response.ErrorList = new List<string>();

            var worksheet = ep.Workbook.Worksheets[1];
            for (var row = 1; row <= worksheet.Dimension.End.Row; row +=8)
            {
                try
                {
                    var prueba = new PiezaRow
                    { };
                    prueba.Pieza = Convert.ToString(worksheet.Cells[row , 1].Value ?? "");
                    prueba.GrosTab = Convert.ToDecimal(worksheet.Cells[row + 2, 1].Value ?? 0);
                    prueba.Enchapado = Convert.ToString(worksheet.Cells[row +3, 1].Value ?? "");
                    prueba.MtsEnchapado = Convert.ToDecimal(worksheet.Cells[row +5, 1].Value ?? 0);
                    prueba.MtsCorte = Convert.ToDecimal(worksheet.Cells[row +7, 1].Value ?? 0);


                    new PiezaRepository().Create(uow, new SaveRequest<MyRow>
                    {
                        Entity = prueba
                    });

                    response.Inserted = response.Inserted + 1;


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
