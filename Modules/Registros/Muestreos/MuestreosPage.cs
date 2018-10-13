
namespace Miapp2.Registros.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.MuestreosRow))]
    public class MuestreosController : Controller
    {
        [Route("Registros/Muestreos")]
        public ActionResult Index()
        {
            return View("~/Modules/Registros/Muestreos/MuestreosIndex.cshtml");
        }
    }
}