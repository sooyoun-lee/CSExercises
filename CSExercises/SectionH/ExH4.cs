﻿namespace CSExercises
{
    //Write a static method:  Substitute(string s, char c1, char c2) that would 
    //return a string. The method should find all occurrences of the character c1 
    //in the string s and substitute c1 with character c2.  The new word so formed would 
    //be the return value of this method. 
    public class ExH4
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string newString = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1) newString = newString + c2;
                else newString = newString + s[i];
            }
            return s;
        }
    }
}
