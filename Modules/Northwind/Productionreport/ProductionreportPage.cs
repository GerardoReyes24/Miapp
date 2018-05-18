
namespace Miapp2.Northwind.Pages
{
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProductionreportRow))]
    public class ProductionreportController : Controller
    {
        [Route("Northwind/Prodcutionreport")]
        public ActionResult Productionreport()
        {
            return View(MVC.Views.Northwind.Productionreport.Index);
        }
    }
}
