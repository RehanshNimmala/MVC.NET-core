namespace CalculateOccupancy.Models
{
    public class Model
    {
        public double capacity { get; set; }
        public double bulkDensity { get; set; }
        public double quantity { get; set; }
        public double CalculateOccupancy()
        {
            double occupancy =quantity/(capacity*bulkDensity)*100;
            return occupancy;
        }

    }
}
