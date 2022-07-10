namespace NimmalaWeek2R.Models
{
    // Created by Nimmala
    public class HelloModel
    {
        //Creating two properties.1)Name 2) Number for holding
        public string? Name { get; set; }
        public int Number { get; set; }

        //Creating two methods, one for finding the square of the number,
        //other for findimg the cube for the number
        public int GetSquare()
        {
            return (int)Math.Pow( Number, 2);
        }// Get Square

        public int GetCube()
        {
            return(int) Math.Pow( Number,3);
        }//Get Cube()

    }//End Hello Model
}//Namespace
