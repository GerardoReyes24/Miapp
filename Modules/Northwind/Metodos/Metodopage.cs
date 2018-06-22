
namespace Miapp2.Northwind.Pages
{
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;
    using Miapp2.Northwind.Endpoints;
    using System.Data;
    using Serenity.Services;
    using System.Data.SqlClient;
    using Serenity.Data;
    using Miapp2.Northwind.Entities;

    public class MetodController : Controller
    {
        private MetodosController met = new MetodosController();
        private MetodosRow metodo = new MetodosRow();
        IDbConnection sqlconection = SqlConnections.NewFor<MetodosRow>();
  


        [Route("Northwind/Met")]
        public ActionResult index()
        {
          
            
            return View(MVC.Views.Northwind.Metodos.mimetod, sqlconection.List<MetodosRow>());
        }
        

        [Route("Northwind/Met/Delete")]
        public ActionResult delete(int id)
        {

            var v = new DeleteRequest();
            v.EntityId = id;
            var m = new UnitOfWork(sqlconection);
            met.Delete(m, v);
            return Redirect("~/Northwind/Met");
        }

    

    
        
    }
}
