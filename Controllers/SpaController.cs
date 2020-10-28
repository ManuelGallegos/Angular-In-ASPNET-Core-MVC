using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Hosting;

namespace Angular_In_ASPNET_Core_MVC.Controllers
{
    public class SpaController : Controller
    {
        public IActionResult Index([FromServices] IWebHostEnvironment env)
        {
            return new PhysicalFileResult(env.WebRootPath + "/index.html", "text/html");
        }
    }
}
