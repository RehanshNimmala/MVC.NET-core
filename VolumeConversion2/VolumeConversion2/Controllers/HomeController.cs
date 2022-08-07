using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VolumeConversion2.Models;

namespace VolumeConversion2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Model());
        }
        [HttpPost]
        public IActionResult Index(Model gallon)
        {
            return View("Results", gallon);
        }
    }
}