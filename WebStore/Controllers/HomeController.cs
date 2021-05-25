using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration Configuration;
        public HomeController (IConfiguration Configuration) 
        { 
            this.Configuration = Configuration; 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SecondAction()
        {
            return Content(Configuration ["Greetings"]);
        }
    }
}
