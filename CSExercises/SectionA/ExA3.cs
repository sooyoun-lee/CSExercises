using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes an integer as input and prints the square of that number
    //For this exercise, the input and output has been implemented for you in the template
    //You need to implement the square function

    public class ExA3
    {
        public static void Main(string[] args)
        {
            Console.Write("Write an integer: ");
            string inputString = Console.ReadLine();
            int inputInt = Convert.ToInt32(inputString);

            Console.WriteLine("The suquare of the number is: ");
            int result = square(inputInt);

            Console.WriteLine(result);
        }

        public static int square(int x)
        {
            double squareResult = Math.Pow(x,2.0);
            int output = Convert.ToInt32(squareResult);
 
            return output;

        }
    }
}
