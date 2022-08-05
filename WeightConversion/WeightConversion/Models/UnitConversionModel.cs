using System.ComponentModel.DataAnnotations;

namespace WeightConversion.Models

{
    public class UnitConversionModel
    {
        [Required(ErrorMessage ="please enter the weight")]
        [Display(Name ="please enter weight as integer or decimal")]
        public double Weight { get; set; }
        public string? WeightUnit { get; set; }

        public double ConvertWeight()
        {
            double conversionResult = 0;
            double result = 0;
            switch (WeightUnit)
            {
                case "Kg2P":
                    conversionResult = Weight * 2.205;
                   result =conversionResult;    
                    break;
                case "P2Kg":
                    conversionResult = Weight / 2.205;
                   // result = conversionResult;   
                    break;
            }
            return conversionResult;

        }

    }
}
