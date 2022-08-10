
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



        public string? GetName()
        {
            if (Gender == "Male")
            {
                Name = "Mr." +""+ Name;
            }
            else if (Gender == "Female")
            {
                Name = "Mrs." +""+ Name;

            }
            return Name;
        }


        public double CalculateBMI()
        {
            //string? value = "";
            double bmi = (Weight / Height / Height) * 10000;
            double result = Math.Round(bmi, 2);
            return result;
       }
        //public string

        //    if (result <= 18.5)
        //    {
        //        value = ("you're in the underweight range.");
        //    }
        //    else if (result > 18.5 & result < 24.9)
        //    {

        //        value = ("you're in the Normal range.");

        //    }
        //    else if (result > 24.9 & result < 29.9)
        //    {

        //        value = ("you're in the Over Weight range.");

        //    }
        //    else if (result > 30 & result < 39.9)
        //    {

        //        value = ("you're in the Obese range.");
        //    }
        //    return result;
            
        //}


        

    }
}
