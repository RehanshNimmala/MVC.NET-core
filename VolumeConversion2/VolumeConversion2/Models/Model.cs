namespace VolumeConversion2.Models
{
    public class Model
    {
        public double quantity { get; set; }

        //public double volume { get; set; }

        public double CalculateInGallon()
        {
            double gallon = quantity / 3.785;
            return gallon;
        }
    }
}
