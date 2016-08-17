using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            string[] names = new string[] { "John", "Venkat", "Mary", "Virtor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };

            ExF2.Sort(marks);

            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int k = i + 1; k < names.Length; k++)
                {
                    if (names[i].CompareTo(names[k]) > 0)
                    {
                        string tmp = names[i];
                        names[i] = names[k];
                        names[k] = tmp;
                    }
                }
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }








        }
    }
}
