using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StringsAndInts
{
    class Program
    {
        static void Main(string[] args)
        {
            try //loop through a list of ints and divide each by a user generated number, printing result to user.
            {
                List<int> ints = new List<int> { 12, 45, 72, 38, 1247, 5 };
                Console.WriteLine("Input a number to divide numbers by");
                int choice = Convert.ToInt32(Console.ReadLine());
                foreach (int i in ints)
                {
                    Console.WriteLine(i + " / " + choice + " = " + i/choice);
                }
            }
            catch (DivideByZeroException) //display a message in the user tries to divide by 0.
            { 
                Console.WriteLine("Please don't divide by 0.");
            }
            catch (FormatException) //display a message if user enters a non-number.
            {
                Console.WriteLine("Please only enter a number.");
            }
            finally //display a message that try/catch has completed, and wait for a key input to close program.
            { 
                Console.WriteLine("Try/catch block complete, continuing execution");
                Console.ReadLine(); 
            }
        }
    }
}
