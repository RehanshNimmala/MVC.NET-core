using Microsoft.AspNetCore.Mvc;
using practise2.Models;


namespace practise2.Controllers
{
    
    public class HomeController : Controller
    {
        

        [HttpGet]  
        public IActionResult Index()
        {
            return View(new Agemodel());
        }
        [HttpPost]
        public IActionResult Index(Agemodel m)
        {
           
            

            return View("Hello", m);
        }
    }
}