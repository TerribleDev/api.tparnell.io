using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace api.tparnell.io.Controllers
{
    public class SocialController : Controller
    {
        private static readonly Dictionary<string, string> endpoints = new Dictionary<string, string>
        {
            ["Linkedin"] = "https://www.linkedin.com/in/tommy-parnell-63a72224",
            ["Twitter"] = "https://twitter.com/TerribleDev",
            ["Github"] = "https://github.com/tparnell8"
        };

        public IActionResult Index() => new JsonResult(endpoints, new Newtonsoft.Json.JsonSerializerSettings() { Formatting = Newtonsoft.Json.Formatting.Indented });
    }
}