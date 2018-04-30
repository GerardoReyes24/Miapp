
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProductionStRow))]
    public class ProductionStController : Controller
    {
        [Route("Northwind/ProductionSt")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/ProductionSt/ProductionStIndex.cshtml");
        }
    }
}