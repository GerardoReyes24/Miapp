using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Miapp2.Web.Modules.IntOut
{
    public class IntOutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}