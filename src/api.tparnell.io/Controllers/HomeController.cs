using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ApiExplorer;

namespace api.tparnell.io.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<string> endpoints = new List<string> {
            "/Resume",
            "/Conference",
            "/Websites",
            "/Social"
        };

        public IActionResult Index() => new JsonResult(endpoints, new Newtonsoft.Json.JsonSerializerSettings() { Formatting = Newtonsoft.Json.Formatting.Indented });

        public string Error()
        {
            return "Oh noes error!";
        }
    }
}