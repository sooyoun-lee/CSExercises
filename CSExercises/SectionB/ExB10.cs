using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            Console.Write("Write the length of a: ");
            string aStr = Console.ReadLine();
            Console.Write("Write the length of b: ");
            string bStr = Console.ReadLine();
            Console.Write("Write the length of c: ");
            string cStr = Console.ReadLine();

            double a = Convert.ToDouble(aStr);
            double b = Convert.ToDouble(bStr);
            double c = Convert.ToDouble(cStr);

            double area = CalculateArea(a, b, c);

            if (area > 0)
            {
                Console.WriteLine("The area of the triangle is {0}", area);
            }
            else
            {
                Console.WriteLine("The area cannot be calculated.");
            }
        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // The area of triangle cannot be computed if three sides cannot make triangle
            if ( ( a + b ) < c || ( a + c ) < b || ( b + c ) < a )
            {
                area = -1;
            }
            return area;
        }
    }
}