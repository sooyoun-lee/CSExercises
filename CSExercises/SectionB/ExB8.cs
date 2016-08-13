﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            Console.Write("How long is the distance traveled in km?: ");
            string distanceStr = Console.ReadLine();
            double distance = Convert.ToDouble(distanceStr);

            double fare = CalculateFare(distance);
            Console.WriteLine("The fare is {0:0.00}", fare);
        }

        public static double CalculateFare(double distance)
        {
            double fare = 2.4 + distance * 0.4;
            double fareRounded = Math.Round(fare, 1);
            return fareRounded;
        }
    }
}
