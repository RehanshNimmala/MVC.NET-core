using CalculateBulkDensity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculateBulkDensity.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Model());
        }
        [HttpPost]
        public IActionResult Index(Model density)
        {
            return View("Results",density);
        }

       

      
    }
}