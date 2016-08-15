using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the travelled distance in km: ");
            string distanceStr = Console.ReadLine();
            double distance = Convert.ToDouble(distanceStr);

            double fare = CalculateFare(distance);

            Console.WriteLine("${0:0.00}", fare);
        }

        public static double CalculateFare(double distance)
        {
            double fare = 0;
            double distanceCeiling = Math.Ceiling(10 * distance) / 10;

            if (distance <= 0.5)
            {
                fare = 2.40;
            }
            else
            {
                if (distance <= 9)
                {
                    fare = ((distance / 0.1) - 5) * 0.04 + 2.40;
                }
                else
                {
                    fare = ((distance / 0.1) - 90) * 0.05 + (85 * 0.04) + 2.40;
                }
            }
            return fare;



        }
    }
}