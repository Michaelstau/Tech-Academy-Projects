using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating an array of strings, and having the user input a number.
            //If the number matches an index of the array, the user gets a message regarding the item at that index.
            //Otherwise, they're asked to enter a number that matches an index.
            string[] petArray = { "dog", "cat", "pig", "hampster" };
            Console.WriteLine("Theres is an array of pets: input an integer from 0-3 to select a pet from the array");
            string index = Console.ReadLine();
            while (index != "0" && index != "1" && index != "2" && index != "3")
            {
                Console.WriteLine("Please enter a number from 0 to 3.");
                index = Console.ReadLine();
            }
            string pet = petArray[Convert.ToInt16(index)];
            Console.WriteLine("You will now have " + pet + "(s)");

            //Same as above except the array contains integers instead of strings, and final response takes earlier answer into account.
            int[] intArray = { 3, 5, 7, 99 };
            Console.WriteLine("Theres is also an array of numbers: input an integer from 0-3 to select a number from the array");
            index = Console.ReadLine();
            while (index != "0" && index != "1" && index != "2" && index != "3")
            {
                Console.WriteLine("Please enter a number from 0 to 3.");
                index = Console.ReadLine();
            }
            int petNum = intArray[Convert.ToInt16(index)];
            Console.WriteLine("You now have " + petNum + " " + pet + "(s)");

            //Same as above, but with a list containing strings, and final response takes all answers into account. 
            List<string> stringList = new List<string> { "dog house", "cat tree", "hampster cage", "pig pen" };
            Console.WriteLine("Theres is now a list of pet houses: input an integer from 0-3 to select a home for your pet from the list");
            index = Console.ReadLine();
            while (index != "0" && index != "1" && index != "2" && index != "3")
            {
                Console.WriteLine("Please enter a number from 0 to 3.");
                index = Console.ReadLine();
            }
            string petHome = stringList[Convert.ToInt16(index)];
            Console.WriteLine("Your " + petNum + " " + pet + "(s)" + " will live in a glorious " + petHome );
        }
    }
}