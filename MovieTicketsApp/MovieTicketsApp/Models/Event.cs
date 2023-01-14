namespace MovieTicketsApp.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public int CategoryID { get; set; }
        public double TicketPrice { get; set; }
        public string? Description { get; set; }
        public string ImageID { get; set; }
    }
}
