namespace CSExercises
{
    public class ExH3
    {
        //Write a function (static method) that would take in an integer and 
        //return the hexadecimal.  Print out the Hex of all numbers 1 to 100 and 
        //compare your answer with that of the built in function.

        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                System.Console.WriteLine(Hex(i));
            }
        }
        public static string Hex(int i)
        {
            string hex = "";
            string[] hexList = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};

            while(i/16!=0)
            {
              hex = hexList[i % 16] + hex;
                i = i / 16;
            }

            hex = hexList[i % 16] + hex;
                return hex;






        }
    }
}
