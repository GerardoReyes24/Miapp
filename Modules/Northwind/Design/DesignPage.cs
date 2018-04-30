
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.DesignRow))]
    public class DesignController : Controller
    {
        [Route("Northwind/Design")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/Design/DesignIndex.cshtml");
        }
    }
}