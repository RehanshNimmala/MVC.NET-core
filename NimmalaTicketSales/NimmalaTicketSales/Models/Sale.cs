using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

//Created by Naveen Nimmala

//555555555555555

/* This is the supporting model for the Buy view ehich as a form access the class's properties
 * This class has an ovreloaded constructor with two signatures:1) Default constructor,2)one with parameters for Event name
 * for sale and ticket price.
 * The parametrized constructor is called from the cart controller"Buy" action method, to send the sale model 
 * as a view model for sale of a specific event and ticket price that has been selected by the user to receive further information
 * about the event user chooses to buy tickets for(Supports the Buy form)*/
 


namespace NimmalaTicketSales.Models
{
    public class Sale
    {
        /*There are several properties in this class constructor that receives event name and ticket pricce,
        and also a default constructor without any method body or parameters because ther is a defined constructor in 
        the class as well.The default constructor will be needed for binding model.*/
        
        // Two methods:Calculate discount(), ProcessSale()

        //one SelectListItem collection for the drop down

        //For Properties and Variables
        public string? EventName { get; set; }
        public string? CustomerName { get; set; }

        [Required(ErrorMessage ="Email is a required field")]
        [EmailAddress(ErrorMessage ="Please enter a valid email address")]

        public string? Email { get; set; }
        public double TicketPrice { get; set; }
        public string? SaleDate { get; set; }
        [Required(ErrorMessage ="Please enter numbr of Tickets")]
        [Range(1,1000,ErrorMessage ="Number of Tickets should be Minimum 1")]
        public int Count { get; set; }
        public bool SeniorDiscount { get; set; }
        [Required(ErrorMessage ="Please select a deliver option")]
        public string? SelectedDelivery { get; set; }// for dropdown

        //Other Properties
        public double SubTotal { get; set; }
        public double SaleDiscount { get; set; }
        public double DeliveryCharge { get; set; }  
        public double AmountDue { get; set; }

        //Variables for select Dropdown
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

        public Sale(string? eventName,double ticketPrice)
        {
            EventName = eventName;
            TicketPrice = ticketPrice;
        }//Construcor

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
           if(SeniorDiscount==true)
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
        
           

    }// Class
}//namespace
