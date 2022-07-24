using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;



namespace ExamPractise.Models
{
    public class BillModel
    {
        [Required]
        public string? CustomerName { get; set; }
       public string? SoftwareCode { get; set; }
        [Range(1, 100)]
        public int Users { get; set; }
        public List<SelectListItem> SoftwareList { get; set; }  = new List<SelectListItem>
        {
        new SelectListItem{Value="PM", Text="Payroll Management"},
        new SelectListItem{Value="CM", Text="Customer Management"},
        new SelectListItem { Value = "TM", Text = "Training Management" }
        };
        public string GetSelectedSoftware()
        {
            string softwareName = "";
            if (SoftwareCode == "PM")
            {
                softwareName = "Payroll Management";
            }
            else if (SoftwareCode == "CM")
            {
                softwareName = "Customer Management";
            }
            else if (SoftwareCode == "TM")
            {
                softwareName = "Training Management";
            }
            return softwareName;
        }
        private double GetSoftwareRate()
        {
            double rate = 100;
            if (SoftwareCode == "PM")
            {
                rate = 100;
            }
            else if (SoftwareCode == "CM")
            {
                rate = 75;
            }
            else if (SoftwareCode == "TM")
            {
                rate = 80;
            }
            return rate;

        }
        public double GetMonthlyCharge()
        {
            double rate = GetSoftwareRate();
            return this.Users * rate;
        }
    }

}

        
