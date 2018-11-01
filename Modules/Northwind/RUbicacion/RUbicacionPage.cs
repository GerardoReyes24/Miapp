
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.RUbicacionRow))]
    public class RUbicacionController : Controller
    {
        [Route("Northwind/RUbicacion")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/RUbicacion/RUbicacionIndex.cshtml");
        }
    }
}