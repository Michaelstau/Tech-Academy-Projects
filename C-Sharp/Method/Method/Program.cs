using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathy.Add(4));
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number, or nothing.");
            string read = Console.ReadLine();
            try
            {
                int num2 = Convert.ToInt32(read);
                Console.WriteLine(Mathy.Add(num1, num2));
            }
            catch (FormatException)
            {
                if (read == "")
                {
                    Console.WriteLine(Mathy.Add(num1));
                }
                else
                {
                    Console.WriteLine("Only enter a number, or nothing at all please.");
                }
            }
        }
    }
}