﻿using System;

namespace CSExercises
{
    //A company records its monthly sales information in an array 
    //of size 12; where Sales[0] represents January sales, Sales[1] is 
    //February sales etc.  After entering the data the company wants to 
    //perform some queries on the data.  Write a program that would do the following:

    //a.Take in the sales for the 12 months.
    //  Note: You may use the array initialisation inside the program for storing these.
    //b.Print the month when Maximum Sales is recorded.
    //  Note: You may just print 0, 1 etc.  for Jan Feb etc… 
    //c.Print the month where Minimum Sales is recorded.
    //d.Print the average monthly sales for the year.

    //There are at least two ways to implement this:
    //1. Implement one method that calculate all the required info in one pass
    //2. Implement 3 methods each calculating different thing

    public class ExF1
    {
        public static void Main(string[] args)
        {
            int[] sales = new int[12];
            for (int n = 0; n < 12; n++)
            {
                Console.Write("Enter sales for month {0}: " , n);
                sales[n] = Convert.ToInt32(Console.ReadLine());
            }

            int max = 0;
            int min = 0;
            double avg = 0;

            CalculateMinMaxAvg(sales, ref min, ref max, ref avg);

            Console.WriteLine("Maximum Sales: " + max);
            Console.WriteLine("Minimum Sales: " + min);
            Console.WriteLine("Average Sales: " + avg);
        }

        public static void CalculateMinMaxAvg(int[] sales, ref int minMonth, ref int maxMonth, ref double avg)
        {
            int sum = 0;
            minMonth = 0;
            maxMonth = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                sum = sum + sales[i];

                if (sales[i] <= sales[minMonth])
                {
                    minMonth = i;
                }

                if (sales[i] >= sales[maxMonth])
                {
                    maxMonth = i;
                }
            }

            avg = sum / sales.Length;
        }

        public static int CalculateMinMonth(int[] sales)
        {
            int minMonth = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] <= sales[minMonth])
                {
                    minMonth = i;
                }

            }
            return minMonth;

        }

        public static int CalculateMaxMonth(int[] sales)
        {
            int maxMonth = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] >= sales[maxMonth])
                {
                    maxMonth = i;
                }
            }
            return maxMonth;



        }

        public static double CalculateAvgSales(int[] sales)
        {
            int sum = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                sum = sum + sales[i];
            }

            double avg = sum / sales.Length;

            return avg;

        }


    }
}
