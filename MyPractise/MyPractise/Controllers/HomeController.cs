using Microsoft.AspNetCore.Mvc;

namespace MyPractise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string message = "Welcome NAVEEN";

            string todaysDate = DateTime.Now.ToString();

            // creating data for sending to the view
            ViewBag.Message = message;

            ViewBag.TodaysDate = $"Today's date is { todaysDate}";
            return View();
        }


    }
}