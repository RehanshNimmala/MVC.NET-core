using System.ComponentModel.DataAnnotations;
namespace AreaPractise.Models
{
    public class Model
    {
        [Required(ErrorMessage ="Please provide the input")]
        public double number { get; set; }

        public string Getresult()
        {
            if(number %5==0||number%10==00)
            {
                return "Number divisible by 5 and 10";
            }
            else
            {
                return "Number not divisible by 5  and 10";
            }
        }
    }
}
