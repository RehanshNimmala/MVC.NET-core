using KilogramConversion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KilogramConversion.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View(new Model());
        }
        [HttpPost]
        public IActionResult Index(Model pound)
        {
            return View("Results", pound);
        }
    }
}