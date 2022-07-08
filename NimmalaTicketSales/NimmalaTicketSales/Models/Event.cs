namespace NimmalaTicketSales.Models
{
    // Created by Naveen NImmala
    /*
     * 2222222222
     * This class crestes type for the events
     * Each event has an event name which is Title,and description for the event,the category to which the event belongs to,
     * Ticket price for the event, and an Image to display.*/

    public class Event
    {
        public int ID { get; set; }
        public string?Title { get; set; }
        public int CategoryID { get; set; }
        public double TicketPrice { get; set; }
        public string? Description { get; set; }
        public string ImageID { get; set; }
    } 
}
