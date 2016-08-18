using System;

namespace CSExercises
{
    //Write a program for the following:
    //a.Declare an array of dimension 10 (index 0… 9). 
    //b.Generate 50 Random integers in the range 0 … 9.
    //c.Store the number of occurrences(count) in the array appropriately.
    //d.Print a table that would list the numbers and the number of occurrences.

    //Addition:
    //-	Try to print an histogram for the above
    //-	How would the program be affected if the range of numbers randomly generated is between -5 and +5?

    // Sample Output
    // Number Count
    //  0		  4
    //  1		  2
    //  2		  8
    //  3		  6
    //  4		  5
    //  5		  5
    //  6		 11
    //  7		  0
    //  8		  3
    //  9		  6

    //Number	
    //  0	****  
    //  1	**
    //  2	********
    //  3	******
    //  4	*****
    //  5	*****
    //  6	***********
    //  7	
    //  8	***
    //  9	******

    public class ExI2
    {
        public static void Main(string[] args)
        {
            int[] index = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbers = new int[50];
            int[] count = new int[10];

            //generate random number for numbers array
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rnd.Next(10);
            }

            //count numbers and save it in count array
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (numbers[j] == index[i])
                    {
                        count[i]++;
                    }
                }
            }

            //Print the table
            Console.WriteLine("Number \t Count");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("   {0} \t    {1}", index[i], count[i]);
            }

            //Print the histogram
            Console.WriteLine("Number");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("   {0} \t", index[i]);
                for (int j = 0; j < count[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }







        }
    }
}
