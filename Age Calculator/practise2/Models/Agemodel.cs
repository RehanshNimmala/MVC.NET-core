using System.ComponentModel.DataAnnotations;

namespace practise2.Models
{
    public class Agemodel
    {
        public string? Name { get; set; }
        [Range(0,2100)]
        public int Year { get; set; }

        // creating the method for calculating the age

        public int GetAge()
        {
            return (int)DateTime.Now.Year - Year;

        }
    }
}
