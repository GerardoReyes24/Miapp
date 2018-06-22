
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
    using Miapp2.ImportFiles.Entities;

    public class CotizaController : Controller
    {
      
        IDbConnection conn =  SqlConnections.NewFor<ProductRow>();
        IDbConnection pb = SqlConnections.NewFor<PiezaRow>();

        [Route("Northwind/Cotiza")]
        public ActionResult index()
        {

        //    ViewBag.materiales = conn.List<PiezaRow>();
            ViewBag.suma = pb.List<PiezaRow>();
                
            
            return View(MVC.Views.Northwind.Cotiza.CotizaIndex);
        }
        


    

    
        
    }
}
