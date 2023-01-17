using Microsoft.AspNetCore.Mvc;
using MovieTicketsApp.Models;
using System.Diagnostics;

namespace MovieTicketsApp.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}