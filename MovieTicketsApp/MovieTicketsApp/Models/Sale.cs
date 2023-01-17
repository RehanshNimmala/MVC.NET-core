namespace MovieTicketsApp.Models
{
    public class Sale
    {
        public string? EventName { get; set; }
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Email is a required field")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]

        public string? Email { get; set; }
        public double TicketPrice { get; set; }
        public string? SaleDate { get; set; }
        [Required(ErrorMessage = "Please enter numbr of Tickets")]
        [Range(1, 1000, ErrorMessage = "Number of Tickets should be Minimum 1")]
        public int Count { get; set; }
        public bool SeniorDiscount { get; set; }
        [Required(ErrorMessage = "Please select a deliver option")]
        public string? SelectedDelivery { get; set; }// for dropdown

        //Other Properties
        public double SubTotal { get; set; }
        public double SaleDiscount { get; set; }
        public double DeliveryCharge { get; set; }
        public double AmountDue { get; set; }

    }
}
