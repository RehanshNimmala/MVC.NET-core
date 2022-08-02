namespace p2.Models
{
    public class HelloModel
    {
       public string Name { get; set; }
        public int Number { get; set; }

        public int GetSquare()
        {
            return(int)Math.Pow(2,Number);
        }
        public int GetCube()
        {
            return(int)Math.Pow(3, Number);
        }
        

    }
}
