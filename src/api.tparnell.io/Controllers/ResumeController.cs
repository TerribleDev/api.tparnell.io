using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace api.tparnell.io.Controllers
{
    public class ResumeController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            using(var t = new HttpClient())
            {
                var data = await t.GetAsync("http://resume.terribledev.io/resume.json");
                this.Response.ContentType = data.Content.Headers.ContentType.MediaType;
                return new FileStreamResult(await data.Content.ReadAsStreamAsync(), data.Content.Headers.ContentType.MediaType);
            }
        }
    }
}