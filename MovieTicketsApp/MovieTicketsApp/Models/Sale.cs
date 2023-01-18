using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

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
    public List<SelectListItem> DeliveryOptions = new List<SelectListItem>
        {
            new SelectListItem{Text ="Mail", Value="Mail"},
            new SelectListItem{Text ="Print",Value="Print at Home"},
            new SelectListItem{Text ="Digital",Value="Digital Ticket"},
            new SelectListItem{Text="Call",Value="Will Call"}
        };
    public Sale()
    {
        //Default constructor without method parameters or body
        //This will be required for binding
    }//Constructor
    public void CalculateDiscount()
    {
        const double SENIOR_DISCOUNT = 0.2D;
        SaleDiscount = SubTotal * SENIOR_DISCOUNT;
    }// Calculate the discount
    public void ProcessSale()
    {
        // Calculates the sale value and sets the sales date
        SaleDate = DateTime.Today.ToShortDateString();
        SubTotal = TicketPrice * Count;
        if (SeniorDiscount == true)
        {
            CalculateDiscount();
        }// Senior Discount

        if (SelectedDelivery == "Mail")
        {
            DeliveryCharge = 3.95;

        }
        else
        {
            DeliveryCharge = 0;
        }
        AmountDue = SubTotal - SaleDiscount + DeliveryCharge;
    }

}
