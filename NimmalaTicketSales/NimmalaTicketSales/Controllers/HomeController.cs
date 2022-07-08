using Microsoft.AspNetCore.Mvc;
using NimmalaTicketSales.Models;
using System.Diagnostics;

namespace NimmalaTicketSales.Controllers
{
    //Created by Naveen Nimmala
    //666666666666

    public class HomeController : Controller
    {
        //Action methods for Home page and About page
  
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