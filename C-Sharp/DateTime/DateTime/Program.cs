using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
            //Create a datetime variable and set it to the current time using datetime, and print it to user.
            //ask user for a number
            //add that number of hours to our datetime variable, and print it to the user.
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Hello, it is currently {0}. How many hours would you like to travel forward in time?", now.ToString());
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime future = DateTime.Now.AddHours(hours); 
            Console.WriteLine("Hello, it is currently {0}.", future);
            Console.ReadLine();

        }
    }
}