using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            string inputStr = Console.ReadLine();
            double input = Convert.ToDouble(inputStr);
            double output = SQRT(input);
            Console.WriteLine("The square root of the number is: {0:0.###;-0.###;0.00}", output);
        }

        public static double SQRT(double x)
        {
            double result = Math.Sqrt(x);
            return result;

        }
    }
}
