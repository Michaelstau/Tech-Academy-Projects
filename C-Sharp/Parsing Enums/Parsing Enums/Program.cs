using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what day of the week is it?");
            //getting user input string, parsing it to Day type and saving it as a variable. Then writing a reply to user.
            try
            {
                
                Day now = (Day)Enum.Parse(typeof(Day), Console.ReadLine().ToLower());
                Console.WriteLine($"Thanks for letting me know it's {now}!");
            }
            //writing user a message if they've input something other than a day of the week.
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            //pausing so user can read message.
            finally
            {
                Console.ReadLine();
            }
        }
        // making an enum type Day.
        public enum Day
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
        }
    }
}