using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string name = "Susan";
            int age = 7;
            DateTime birthday = new DateTime(2013, 1, 18);
            ViewBag.name = name;
            ViewBag.Age = age;
            ViewBag.Birthday = birthday;
            return View();
        }
    }
}
