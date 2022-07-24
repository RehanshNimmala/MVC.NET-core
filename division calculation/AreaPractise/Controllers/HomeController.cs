using AreaPractise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AreaPractise.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Model());
        }
        [HttpPost]
        public IActionResult Index(Model model)
        {
            return View("Result", model);
        }


    }
}