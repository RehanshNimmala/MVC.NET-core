namespace PoundConversion.Models
{
    public class Model
    {
        public double weight { get; set; }

        //public double volume { get; set; }

        public double CalculateKilogram()
        {
            double Kilogram = weight / 2.205;
            return Kilogram;
        }
    }
}
