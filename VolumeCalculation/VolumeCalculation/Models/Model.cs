namespace VolumeCalculation.Models
{
    public class Model
    {
        public double quantity { get; set; }

        //public double volume { get; set; }

        public double CalculateInLiters()
        {
            double liter = quantity * 3.785;
            return liter;
        }
    }
}
