using System.ComponentModel.DataAnnotations;

namespace WeightConversion.Models

{
    public class UnitConversionModel
    {
        [Required(ErrorMessage ="please enter the weight")]
        [Display(Name ="please enter weight as integer or decimal")]
        public double weight { get; set; }
        public string? weightUnit { get; set; }

        public double ConvertWeight()
        {
            double conversionResult = 0;
            string result = "";
            switch (weightUnit)
            {
                case "Kg2P":
                    conversionResult = weight * 2.205;
                    result = $"{weight:N2}Kg  ={conversionResult:N2} Lb";
                    break;

                case "P2Kg":
                    conversionResult = weight / 2.205;
                    result = $"{weight:N2}Lb  ={conversionResult:N2} Kg";
                    break;
            }
            return conversionResult;

        }

    }
}
