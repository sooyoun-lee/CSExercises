namespace CSExercises
{
    public class ExH2
    {
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static int FindWord(string s1, string s2)
        {
            bool inString = false;
            int position = 0;
            string lowerS1 = s1.ToLower();
            string lowerS2 = s2.ToLower();

            for (int j = 0; j < s1.Length - s2.Length + 1; j++)
            {
                if (lowerS1[j] == lowerS2[0])
                {
                    for (int k = 1; k < s2.Length; k++)
                    {
                        if (lowerS1[j + k] == lowerS2[k]) inString = true;
                        else inString = false;
                    }
                    if (inString == true) position = j;
                    break;
                }
            }
            if (inString == false) position = -1;
            return position;

        }
    }
}
