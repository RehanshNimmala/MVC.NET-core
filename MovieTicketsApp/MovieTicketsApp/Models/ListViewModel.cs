namespace MovieTicketsApp.Models
{
    public class ListViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        public List<Category> Categories { get; set; }
        public string? SelectedCategory { get; set; }
        public ListViewModel(IEnumerable<Event> events, List<Category> categories, string? selectedCategory)
        {
            Events = events;
            Categories = categories;
            SelectedCategory = selectedCategory;
        }
    }
}
