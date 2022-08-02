using System.ComponentModel.DataAnnotations;
namespace CalculateBulkDensity.Models
{
    public class Model
    {
        [Required(ErrorMessage ="Please provide the input")]
        
        public double mass { get; set; }

        public double volume { get; set; }

        public double CalculateDensity()
        {
            double density = mass / volume;
            return density;
        }
            
    }
}
