using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your salary: ");
            string yourSalary = Console.ReadLine();

            string yourIncome = CalculateIncome(yourSalary);
            Console.WriteLine("Your income is " + yourIncome);
        }

        public static string CalculateIncome(string salaryStr)
        {
            double salary = Convert.ToDouble(salaryStr);
            double housingAllowance = 0.1 * salary;
            double transportAllowance = 0.03 * salary;
            double Income = salary + housingAllowance + transportAllowance;
            string Incomestr = String.Format("{0:C}",Income);
            return Incomestr;
        }
    }
}
