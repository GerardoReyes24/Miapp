﻿
namespace Miapp2.BasicSamples.Pages
{
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;
    using Miapp2.Northwind.BasicSamples;

     [PageAuthorize, Route("BasicSamples/[action]")] 
    
    public partial class BasicSamplesController : Controller
    {
    }
}
