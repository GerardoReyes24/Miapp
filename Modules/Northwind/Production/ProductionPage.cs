
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProductionRow))]
    public class ProductionController : Controller
    {
        [Route("Northwind/Production")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/Production/ProductionIndex.cshtml");
        }
    }
}