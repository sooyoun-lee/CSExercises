using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            for (int i = 5; i <= 1000; i++)
            {
                if (ExE3.IsPrime(i) == true) Console.WriteLine(i);
            }
        }
    }
}
