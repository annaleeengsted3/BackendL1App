using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FutureValue.Controllers
{
    public class RockbandsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string[] rockbands = new string[] { "ACDC", "Slayer", "Tue", "Wed", "Thu", "Fri", "Sat" };
            ViewBag.Rockbands = rockbands;
            return View();
        }
    }
}
