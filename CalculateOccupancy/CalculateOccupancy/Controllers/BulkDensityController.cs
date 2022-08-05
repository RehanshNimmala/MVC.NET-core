using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace CalculateOccupancy.Controllers
{

    public class BulkDensityController : Controller
        
    {
        public IActionResult Index()
        {
            return View();
            //Index()
        }
        [HttpPost]
        public IActionResult Test(double weight,double volume)
        {
            if (ModelState.IsValid)
            {
                double density = weight / volume;
                ViewBag.Result = $"The Bulk density of the material is {density}";
            }

            //return RedirectToAction("Index","Home",density);
            return View ("Index");
        }
    }
}
