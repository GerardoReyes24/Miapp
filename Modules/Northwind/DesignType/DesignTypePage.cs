
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.DesignTypeRow))]
    public class DesignTypeController : Controller
    {
        [Route("Northwind/DesignType")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/DesignType/DesignTypeIndex.cshtml");
        }
    }
}