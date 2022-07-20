using Microsoft.AspNetCore.Mvc;

namespace MyPractise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string todaysDate = DateTime.Now.ToString();
            string message = "Welcome NAVEEN";
            
            // creating data for sending to the view

            ViewBag.TodaysDate = $"Today's date is { todaysDate}";
            ViewBag.Message = message;
            return View();
        }


    }
}