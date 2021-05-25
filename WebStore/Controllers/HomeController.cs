using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 20 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Петр", Patronymic = "Петрович", Age = 30 },
            new Employee { Id = 2, LastName = "Федоров", FirstName = "Федор", Patronymic = "Федорович", Age = 40 },
        };
        
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

        public IActionResult Employees()
        {
            return View(__Employees);
        }
    }
}
