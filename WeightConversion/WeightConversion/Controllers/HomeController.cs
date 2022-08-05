using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeightConversion.Models;

namespace WeightConversion.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UnitConversionModel());
                
        }
        [HttpPost]
        public IActionResult WeightConversion(UnitConversionModel model)
        {
            return View("Results",model);
        }
            
        

       
    }
}