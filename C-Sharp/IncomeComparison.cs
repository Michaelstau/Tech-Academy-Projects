using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person1 income info.");
            Console.WriteLine("Please input hourly rate: ");

            //Allows user input, converts it to double and saves as a variable
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input hours worked per week");

            //Allows user input, converts it to float and saves as a variable
            float hoursWorked1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Person2 income info.");
            Console.WriteLine("Please input hourly rate: ");

            //Allows user input, converts it to double and saves as a variable
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input hours worked per week");

            //Allows user input, converts it to float and saves as a variable
            float hoursWorked2 = float.Parse(Console.ReadLine());

            //Sets a float variable
            float weeksPerYear = 52.17857f;

            //calculates a double variable using a double and two floats
            double annualSalary1 = hourlyRate1 * (double)hoursWorked1 * (double)weeksPerYear;
            
            //Rounding variable to 2 decimal places
            annualSalary1 = Math.Round(annualSalary1, 2);

            //calculates a double variable using a double and two floats
            double annualSalary2 = hourlyRate2 * (double)hoursWorked2 * (double)weeksPerYear;

            //Rounding variable to 2 decimal places
            annualSalary2 = Math.Round(annualSalary2, 2);

            Console.WriteLine("Annual salary of Person 1: $" + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: $" + annualSalary2);

            //compares two values and saves result as a bool
            bool oneMoreThanTwo = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money that person 2?");
            Console.WriteLine(oneMoreThanTwo);
        }
    }
}