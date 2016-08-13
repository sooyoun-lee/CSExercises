using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            Console.Write("How long is the distance traveled in km?: ");
            string distanceStr = Console.ReadLine();
            double distance = Convert.ToDouble(distanceStr);

            double fare = CalculateFare(distance);
            Console.WriteLine("{0:0.00}", fare);
        }

        public static double CalculateFare(double distance)
        {
            double fare = 2.4 + distance * 0.4;
            double fareCeiling = Math.Ceiling(fare * 10);
            return fareCeiling / 10;
        }
    }
}
