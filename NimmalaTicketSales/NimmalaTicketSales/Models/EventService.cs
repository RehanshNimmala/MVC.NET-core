namespace NimmalaTicketSales.Models
{
    //Created by Naveen Nimmala
    /*
     * 33333333333333333
     * This is a class, which creates a list of events with each event of type  Event(Class)
     * Creates a list of Categories with each Category of type Category(Class)
     * Has three methods:GetEvents() which returns events based on incoming parameter category
     * and GetCategories() that return the list of categories or events.
     * The third methodGetAllEvents()will return all categories */

    public class EventService
    {
        private List<Event> allEvents = new List<Event>()
        {
            new Event()
            {

                ID = 100,
                Title = "The Lion King",
                CategoryID = 1,
                TicketPrice = 50,
                Description = "Musical based on Disney's animated Movie",
                ImageID = "100.png"
            },
            new Event
            {
                ID = 200,
                Title = "Holiday Spectacular",
                CategoryID = 2,
                TicketPrice = 40,
                Description = "Holiday extravaganza for the entire family",
                ImageID = "200.png"
            },
            new Event
            {
                ID = 300,
                Title = "Mary Poppins",
                CategoryID = 1,
                TicketPrice = 50,
                Description = "The Popular Musical with seven Tony awards",
                ImageID = "300.png"

            },
            new Event
            {
                ID = 400,
                Title = "Taylor Swift",
                CategoryID = 2,
                TicketPrice = 90,
                Description = "The Popular singer and Songwriter",
                ImageID = "400.png"
            }
        };



        private List<Category> categories = new List<Category>
        {
               new Category()
               {
                    ID=1,
                    Name="Theater Show"

               },
               new Category()
               {
                   ID=2,
                   Name="Concert"

               }
        };
        
        
    
        public Event GetEvent(int id)
        {
            //Incoming parameter id comes from the <a> linl in the details view,
            //where id is either"All", or specific Category name(@cat.Name)
            //Finds an event based on ID
            Event? selectedEvent = null;
            foreach (Event anEvent in allEvents)
            {
                if (anEvent.ID == id)
                {
                    selectedEvent = anEvent;
                }// if
            }
            return selectedEvent;
        }//GetEvent()
        public List<Category> GetCategories()
        {
            //returns categories as a list
            return categories;
        }//GerCategories
        public List<Event> GetAllEvents()
        {
            return allEvents;// returns all events
        }
    }//EventService

}//namespace
