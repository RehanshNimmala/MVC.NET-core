namespace KilogramConversion.Models
{
    public class Model
    {
        public double weight { get; set; }

        //public double volume { get; set; }

        public double CalculatePound()
        {
            double pound = weight * 2.205;
            return pound;
        }
    }
}
