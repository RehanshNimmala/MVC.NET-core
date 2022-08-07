using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VolumeCalculation.Models;

namespace VolumeCalculation.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Model());
        }
        [HttpPost]
        public IActionResult Index(Model liter)
        {
            return View("Results", liter);
        }
    }
}