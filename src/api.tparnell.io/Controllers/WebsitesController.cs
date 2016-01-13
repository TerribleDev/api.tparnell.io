using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace api.tparnell.io.Controllers
{
    public class WebsitesController : Controller
    {
        private static readonly Dictionary<string, IEnumerable<string>> endpoints = new Dictionary<string, IEnumerable<string>>
        {
            ["AboutMe"] = new List<string>() { "about.tommyparnell.com", "about.tparnell.io" },
            ["Resume"] = new List<string>() { "resume.tommyparnell.com", "resume.tparnell.io" },
            ["LetMeLycosThatForYou"] = new List<string>() { "lmltfy.xyz" },
            ["api"] = new List<string>() { "api.tparnell.io" },
            ["dotnetmashup"] = new List<string>() { "dotnetmashup.azurewebsites.net" }
        };

        public IActionResult Index() => new JsonResult(endpoints, new Newtonsoft.Json.JsonSerializerSettings() { Formatting = Newtonsoft.Json.Formatting.Indented });
    }
}