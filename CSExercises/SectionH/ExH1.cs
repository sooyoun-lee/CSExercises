namespace CSExercises
{
    public class ExH1
    {
        public static void Main()
        {
            bool inString = InString("The", "bras");
            System.Console.WriteLine(inString);
        }
        public static bool InString(string s1, string s2)
        {
            bool inString = false;
            int position = 0;
            string lowerS1 = s1.ToLower();
            string lowerS2 = s2.ToLower();

                for (int j = 0; j < s1.Length - s2.Length + 1; j++)
                {
                    if (lowerS1[j] == lowerS2[0])
                    {
                    inString = true;
                        for (int k = 1; k < s2.Length; k++)
                        {
                        if (lowerS1[j+k] == lowerS2[k]) inString = true;
                        else inString = false;
                        }
                    if (inString == true) position = j;
                    break;
                    }
                }
            
            return inString;




        }
    }
}
