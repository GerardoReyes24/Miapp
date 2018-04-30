
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProjectDetailsRow))]
    public class ProjectDetailsController : Controller
    {
        [Route("Northwind/ProjectDetails")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/ProjectDetails/ProjectDetailsIndex.cshtml");
        }
    }
}