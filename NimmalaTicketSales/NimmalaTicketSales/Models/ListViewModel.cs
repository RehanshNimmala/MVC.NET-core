namespace NimmalaTicketSales.Models
{
    //Created by Naveen NImmala
    //44444444444444
    
    public class ListViewModel
    {
        public IEnumerable<Event> Events { get; }
        public List<Category> Categories { get; set; }
        public string? SelectedCategory { get;  }
        public ListViewModel(IEnumerable<Event> events,List<Category>categories, string selectedCategory)
        {
            Events = events;
            Categories = categories;
            SelectedCategory = selectedCategory;
        }//Constructor
    }
}//namespace
