
namespace Miapp2.ImportFiles.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PruebaRow))]
    public class PruebaController : Controller
    {
        [Route("ImportFiles/Prueba")]
        public ActionResult Index()
        {
            return View("~/Modules/ImportFiles/Prueba/PruebaIndex.cshtml");
        }
    }
}