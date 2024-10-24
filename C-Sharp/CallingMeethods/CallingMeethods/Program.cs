using CallingMeethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number to do math on.");
            try
            {   //Getting a number from the user and calling methods from mathIt on that number.
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number + " squared is " + mathIt.squareIt(number));
                Console.WriteLine(number + " doubled is " + mathIt.doubleIt(number));
                Console.WriteLine(number + " times 0 is " + mathIt.zeroIt(number));
                Console.ReadLine();
            }
            catch (FormatException) //Catching format exceptions if user inputs strings or floats.
            {
                Console.WriteLine("PLease only enter whole numbers");
                Console.ReadLine();
            } 
            catch (Exception ex) //catching unforseen exceptions.
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            
        }
    }
}