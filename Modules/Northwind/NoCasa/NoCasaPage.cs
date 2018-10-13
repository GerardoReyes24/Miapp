
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.NoCasaRow))]
    public class NoCasaController : Controller
    {
        [Route("Northwind/NoCasa")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/NoCasa/NoCasaIndex.cshtml");
        }
    }
}