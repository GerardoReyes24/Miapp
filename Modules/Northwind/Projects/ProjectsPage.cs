
namespace Miapp2.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProjectsRow))]
    public class ProjectsController : Controller
    {
        [Route("Northwind/Projects")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/Projects/ProjectsIndex.cshtml");
        }
    }
}