﻿using System;

namespace CSExercises
{
    //Given a number find out its factorial.  

    //Write two different C# program variations for 
    //the problem:
    //a.Using increment counter
    //b.Using a decrement counter.

    //Carefully study the similarities and differences 
    //between the two approaches.
    //List the conditions, if any, under which your program 
    //is likely to fail

    public class ExE1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact1 = CalculateFactorialInc(n);
            Console.WriteLine(fact1);

            int fact2 = CalculateFactorialDec(n);
            Console.WriteLine(fact2);
        }

        public static int CalculateFactorialInc(int n)
        {
            int fac = 1;

            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }

            return fac;
        }

        public static int CalculateFactorialDec(int n)
        {
            int fac = 1;

            for (int i = n; i > 0; i--)
            {
                fac = fac * i;
            }
            return fac;
        }

    }
}
