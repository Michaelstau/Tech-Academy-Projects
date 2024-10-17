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
            //Writes info about the program, and a question to the user.
            Console.WriteLine("The Tech Academy. \nStudent Daily Report.");
            Console.WriteLine("What is your name");

            //Allows user to type a response, and saves it as a string.
            string name = Console.ReadLine();

            //Writes a question to the user. 
            Console.WriteLine("What course are you on?");

            //Allows user to type a response, and saves it as a string.
            string course = Console.ReadLine();

            //Writes a question to the user.
            Console.WriteLine("What page number?");

            //Allows user to type a response, and saves it as an int.
            int PageNum = Convert.ToInt32(Console.ReadLine());

            //Writes a question to the user.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \" \"false.\"");

            //Allows user to type a response, and saves it as a bool.
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            //Writes a question to the user.
            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");

            //Allows user to type a response, and saves it as a string.
            string experiances = Console.ReadLine();

            //Writes a question to the user.
            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");

            //Allows user to type a response, and saves it as a string.
            string feedback = Console.ReadLine();

            //Writes a message to the user.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}