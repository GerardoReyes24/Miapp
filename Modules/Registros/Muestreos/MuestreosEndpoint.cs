
namespace Miapp2.Registros.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using Microsoft.AspNetCore.Mvc;
    using MyRow = Entities.MuestreosRow;
    using Miapp2.Northwind.Entities;
    using System;
    using Serenity.Reporting;
    using Serenity.Web;

    [Route("Services/Registros/Muestreos/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class MuestreosController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {

            var regist = MyRow.Fields;
            var mater = ProductRow.Fields;
            var objeto = request.Entity;

            var product = uow.Connection.TryFirst<ProductRow>(q => q
                       .Select(mater.ProductID, mater.UnitsInStock, mater.UnitPrice)
                       .Where(mater.ProductID == Convert.ToString(objeto.ProductId)));

            if (product == null)
                product = new ProductRow
                {

                };
            else
            {

                product.TrackWithChecks = false;
            }

           
            if (product.UnitsInStock == objeto.CantidadAMuestrear)
            {
                objeto.CantidadContada = 0;
            }
            else
            {
                objeto.CantidadContada = (product.UnitsInStock - objeto.CantidadAMuestrear);
                objeto.DesviacionEconomica = (objeto.CantidadContada * product.UnitPrice);
            }



            /* var objetoo = request.Entity;


             if (objetoo.CantidadAMuestrear < objetoo.CantidadContada)
             {
                 throw new ValidationError("La cantidad contada no puede ser");
             }
             else
             {
                 
             }*/
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        public FileContentResult ListExcel(IDbConnection connection, ListRequest request)
        {
            var data = List(connection, request).Entities;
            var report = new DynamicDataReport(data, request.IncludeColumns, typeof(Columns.MuestreosColumns));
            var bytes = new ReportRepository().Render(report);
            return ExcelContentResult.Create(bytes, "ProductList_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }


    }
}
