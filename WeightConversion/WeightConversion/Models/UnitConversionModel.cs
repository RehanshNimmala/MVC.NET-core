using System.ComponentModel.DataAnnotations;
namespace WeightConversion.Models

{
    public class UnitConversionModel
    {
        [Required(ErrorMessage ="please enter the weight")]
        [Display(Name ="please enter weight as integer or decimal")]
        public double Weight { get; set; }
        public string? WeightUnit { get; set; }

        public string ConvertWeight()
        {
            double conversionResult = 0;
            string result = "";
            switch (WeightUnit)
            {
                case "Kg2P":
                    conversionResult = Weight * 2.205;
                    result =conversionResult.ToString();    
                    break;
                case "P2Kg":
                    conversionResult = Weight / 2.205;
                    result = conversionResult.ToString();   
                    break;
            }
            return result;

        }

    }
}
