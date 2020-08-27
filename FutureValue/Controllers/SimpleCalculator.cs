using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; //REMEMBER TO ADD THIS LINE WHEN USING AN [HHTP]


namespace FutureValue.Controllers
{
    public class SimpleCalculator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //POST: FormHandler
        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            decimal number1 = Convert.ToDecimal(formCollection["number1"]);
            decimal number2 = Convert.ToDecimal(formCollection["number2"]);

            string thisOperator = formCollection["operator"].ToString();

            //int caseSwitch = 1;

            switch (thisOperator)
            {
                case "+":
                    ViewBag.Result = number1 + number2;
                    break;
                case "-":
                    ViewBag.Result = number1 - number2;
                    break;
                case "*":
                    ViewBag.Result = number1 * number2;
                    break;
                case "/":
                    ViewBag.Result = number1 / number2;
                    break;
            }

            return View();
        }
    }
}
