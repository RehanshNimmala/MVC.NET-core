
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DropdownPractise.Models
{
    public class BMICalculation
    {
        public string? Name { get; set; }    
        public double Weight { get; set; }
        public double Height { get; set; }
        public string? Gender { get; set; }

        public List<SelectListItem> GenderList { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem {Text="Male" },
            new SelectListItem {Text="Female"}

        };
        public double CalculateBMI()
        {
            double bmi = (Weight / Height/Height)* 10000;
            double result=Math.Round(bmi,2);

            return result;
        }

    }
}
