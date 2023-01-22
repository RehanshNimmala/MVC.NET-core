using Microsoft.AspNetCore.Mvc;
using MovieTicketsApp.Models;

namespace MovieTicketsApp.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult EventList(string id = "All")
        {
            // uses EventService to get the events, eithr all if no incoming value, or based on Id of event

            //Instantiate the EventService class
            EventService eventService = new EventService();

            //List of Categories
            List<Category> categories = eventService.GetCategories();//gets all categories

            //List of events
            List<Event> events = new List<Event>();//Instantiate the Events list

            //get the event based on ctegory id
            if (id == "All")
            {
                events = eventService.GetAllEvents();//Gets all events from event service

            }
            else
            {
                //Id user asks for category of events, so based on id find the category
                //then use the category to return all events of that type

                int selectedCategoryId = 0;

                //loop through the categories to find the category Id

                foreach (Category cat in categories)
                {
                    if (cat.Name == id)
                    {
                        selectedCategoryId = cat.ID;
                    }
                }// foreach to find the category

                foreach (Event anEvent in eventService.GetAllEvents())
                {
                    if (anEvent.CategoryID == selectedCategoryId)
                        events.Add(anEvent);
                }// foreach for finding events
            }
            //this action method uses a view model:ListViewModel in order to return the collecton of events
            ListViewModel viewModel = new ListViewModel(events, categories, id);//constructor for ListViewModel takes three arguments

            return View(viewModel);

        }
        public IActionResult Details(int id)
        {
            EventService eventService = new EventService();
            Event oneEvent = eventService.GetEvent(id);

            return View(oneEvent);
        }//Details()
    }
}