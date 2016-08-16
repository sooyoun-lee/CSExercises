using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            string[] words = phrase.Split();
            string title = "";

            for (int i = 0; i < words.Length; i++)
            {
                string first = words[i].Substring(0, 1);
                string rest = words[i].Substring(1, words[i].Length - 1);
                first = first.ToUpper();
                words[i] = first + rest;
                if (i != words.Length - 1)
                {
                    title = title + words[i] + " ";
                }
                else
                {
                    title = title + words[i];
                }
            }

            return title;


        }
    }
}
