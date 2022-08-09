using DropdownPractise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DropdownPractise.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BMICalculation());
        }
        [HttpPost]
        public IActionResult CalculateBMI(BMICalculation model)
        {
            return View("Results",model);
        }
    }
}