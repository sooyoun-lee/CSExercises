using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a three-digit integer: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);

            bool answer = IsArmstrongNumber(number);
            Console.WriteLine(answer);
        }


        public static bool IsArmstrongNumber(int n)
        {
            int c = n % 10;
            int b = (n % 100 - c) / 10;
            int a = ((n - b - c) / 100);

            if (n == Math.Pow(a,3)+ Math.Pow(b, 3)+ Math.Pow(c, 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}