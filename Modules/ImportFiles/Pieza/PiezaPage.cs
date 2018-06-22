
namespace Miapp2.ImportFiles.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PiezaRow))]
    public class PiezaController : Controller
    {
        [Route("ImportFiles/Pieza")]
        public ActionResult Index()
        {
            return View("~/Modules/ImportFiles/Pieza/PiezaIndex.cshtml");
        }
    }
}