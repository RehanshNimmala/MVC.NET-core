using Microsoft.AspNetCore.Mvc;

using p2.Models;

namespace p2.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {

            return View(new HelloModel() );

        }
        [HttpPost]
        public IActionResult Index(HelloModel abc)
        { 
        
        return View("Hello", abc);

        }





    }
}