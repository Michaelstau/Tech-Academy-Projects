using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args) 
            //initialize result for our class method to output to, ask user for input number (and convert to int),
            //call Class1.Method using input number, and print output result
            //get 2nd number from user to use with first number in overloaded Class1.Method and print output result
        {
            int result = 0;
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Class1.Method(num, out result);
            Console.WriteLine(result);
            Console.WriteLine("Input another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Class1.Method(num, out result, num2);
            Console.WriteLine(result);
        }
    }
}