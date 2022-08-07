using Microsoft.AspNetCore.Mvc;
using PoundConversion.Models;
using System.Diagnostics;

namespace PoundConversion.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Model());
        }
        [HttpPost]
        public IActionResult Index(Model kg)
        {
            return View("Results", kg);
        }

    }
}