using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ApiExplorer;

namespace api.tparnell.io.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment env;

        private static readonly List<string> endpoints = new List<string> {
            "/Resume",
            "/Conference",
            "/Websites",
            "/Social",
            "/Endpoints"
        };

        public HomeController(IHostingEnvironment env)
        {
            this.env = env;
        }

        public IActionResult Index() =>
            new VirtualFileResult("index.html", new Microsoft.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

        [Route("Endpoints")]
        public IActionResult Endpoints() => new JsonResult(endpoints);

        public string Error()
        {
            return "Oh noes error!";
        }
    }
}