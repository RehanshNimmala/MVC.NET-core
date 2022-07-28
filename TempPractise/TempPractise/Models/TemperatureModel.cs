using System.ComponentModel.DataAnnotations;

namespace TempPractise.Models
{
    public class TemperatureModel
    {
        [Required(ErrorMessage="Please enter the temperature")]
        [Display(Name="Please enter temperature as a integer or decimal")]
        public decimal Temperature { get; set; }
        [Required(ErrorMessage="Please select F or C")]
        public string? TemperatureUnit { get; set; }

        public string ConvertTemp()
        {
            decimal conversionResult = 0;
            string result = "";
            switch(TemperatureUnit)
            {
                case "F2C":
                    conversionResult = (Temperature - 32) * 5 / 9;
                    result = $"{Temperature:N4}degrees F ={conversionResult:N4} degrees C";
                    break;
                case "C2F":
                    conversionResult = (Temperature * 9 / 5) + 32;
                    result =$"{ Temperature:N4}&deg; C={conversionResult:N4}& deg; F";
                    break;
            }
            return result;
        }


    }
}
