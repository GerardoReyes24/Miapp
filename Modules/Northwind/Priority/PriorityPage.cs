
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PriorityRow))]
    public class PriorityController : Controller
    {
        [Route("Northwind/Priority")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/Priority/PriorityIndex.cshtml");
        }
    }
}