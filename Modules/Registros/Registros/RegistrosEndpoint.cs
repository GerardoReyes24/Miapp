
namespace Miapp2.Registros.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using Microsoft.AspNetCore.Mvc;
   
    using MyRow = Entities.RegistrosRow;
    using Miapp2.Registros.Entities;
    using Miapp2.Northwind.Entities;
    using System;
    using Miapp2.Northwind.Repositories;

    [Route("Services/Registros/Registros/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class RegistrosController : ServiceEndpoint
    {
      


        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            var regist = RegistrosRow.Fields;
            var mater = ProductRow.Fields;
            var objeto = request.Entity;

            var product = uow.Connection.TryFirst<ProductRow>(q => q
                       .Select(mater.ProductID, mater.UnitsInStock)
                       .Where(mater.ProductID == Convert.ToString(objeto.ProductId)));

            if (product == null)
                product = new ProductRow
                {

                };
            else
            {

                product.TrackWithChecks = false;
            }


            if ((int)objeto.Movimiento == (int)TipoMovimiento.Entrada )
            {
                product.UnitsInStock = Convert.ToDecimal(product.UnitsInStock + objeto.Cantidad);
            }
            else
            {
                product.UnitsInStock = Convert.ToDecimal(product.UnitsInStock - objeto.Cantidad);
            }



            new ProductRepository().Update(uow, new SaveRequest<ProductRow> { Entity = product, EntityId = product.ProductID });

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


        private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}
