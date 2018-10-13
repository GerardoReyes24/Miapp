
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProyectoRRow))]
    public class ProyectoRController : Controller
    {
        [Route("Northwind/ProyectoR")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/ProyectoR/ProyectoRIndex.cshtml");
        }
    }
}