using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace api.tparnell.io.Controllers
{
    public class ConferenceController : Controller
    {
        private static readonly List<object> Conferences = new List<object>() {
        new {Name = "Monitorama", Year = 2014},
        new {Name = "DevOps Enterprise", Year = 2014},
        new {Name = "DevOps Days Boston", Year = 2014},
        new {Name = "Monitorama", Year = 2015},
        new {Name = "Monitorama", Year = 2016}
        };

        // GET: /<controller>/
        public IActionResult Index()
        {
            return new JsonResult(Conferences, new Newtonsoft.Json.JsonSerializerSettings() { Formatting = Newtonsoft.Json.Formatting.Indented });
        }
    }
}