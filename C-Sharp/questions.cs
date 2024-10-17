using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            //take input, convert to int and save in a variable
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");

            //take input, convert to bool and save in a variable
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");

            //take input, convert to int and save in a variable
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");

            //using a series of comparisons and and statements determine what value to write to screen
            Console.WriteLine(age > 15 && tickets <= 3 && DUI == false);
        }
    }
}