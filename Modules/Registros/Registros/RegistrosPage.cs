
namespace Miapp2.Registros.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.RegistrosRow))]
    public class RegistrosController : Controller
    {
        [Route("Registros/Registros")]
        public ActionResult Index()
        {
            return View("~/Modules/Registros/Registros/RegistrosIndex.cshtml");
        }
    }
}