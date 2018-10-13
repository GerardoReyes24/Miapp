
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.TipoMuebleRow))]
    public class TipoMuebleController : Controller
    {
        [Route("Northwind/TipoMueble")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/TipoMueble/TipoMuebleIndex.cshtml");
        }
    }
}