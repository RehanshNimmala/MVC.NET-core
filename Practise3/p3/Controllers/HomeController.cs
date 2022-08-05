using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace p3.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int number)
        {
            int result=(int)Math.Pow(number, 2);
            ViewBag.result = $"The Square of the numbers entered is {number}is {result}";
            return View();
        }

        [HttpPost]
        public IActionResult WithName(double number, string name)
        {
            string wheel = "";
            switch(number)
            {
                case 1: wheel = "You won $10";
                    break;
                    case 2: wheel = "You won $20";
                    break ;     
                    case 3: wheel = "You won $30";
                    break;
                    default: wheel = "You won $1";
                    break;
            }
            ViewBag.Result=$"Hello{name}.You entered{number}.The gift for you is:{wheel}";
            return View("Index");

        }
        
        

        
    }
}