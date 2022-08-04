using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace CalculateOccupancy.Controllers
{
    public class BulkDensityController : Controller
        
    {
        [HttpPost]
        public IActionResult Index(double weight,double volume)
        {
            double density = weight / volume;
            ViewBag.Result= $"The Bulk density of the material is {density}";

            return RedirectToAction("Index","Home",density);
            //return View("Index");
        }
    }
}
