using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the (x,y) coordinates of two points.");
            Console.Write("x1:\t");
            string x1str = Console.ReadLine();
            Console.Write("y1:\t");
            string y1str = Console.ReadLine();
            Console.Write("x2:\t");
            string x2str = Console.ReadLine();
            Console.Write("y2:\t");
            string y2str = Console.ReadLine();

            double x1 = Convert.ToDouble(x1str);
            double y1 = Convert.ToDouble(y1str);
            double x2 = Convert.ToDouble(x2str);
            double y2 = Convert.ToDouble(y2str);

            double distanceBtw = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine("{0}", distanceBtw);
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }
    }
}
