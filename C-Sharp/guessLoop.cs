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
            //greet user and set some initial variable values.
            Console.WriteLine("Welcome to Project Loop, where you guess numbers until you escape the loops");
            double number = 87;
            double guess = 0;

            //enter a while loop where the user enters guesses until guessing 87
            while (guess != number)
            {
                Console.WriteLine("Please guess a number.");
                guess = Convert.ToDouble(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Too high, try again.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (guess == number)
                {
                    Console.WriteLine("Correct! On to round two!");
                }
            }

            //let the user know they'll be guessing a new number from 1-10 and setting the new number.
            Console.WriteLine("Maybe that was too hard. Now the number is between 1 and 10, but no hints. Good luck");
            number = 9;

            //enter a do while loop with a (fairly unnecissary) switch statement (just for practice).
            // Where the user guesses numbers till they guess 9.
            do
            {
                Console.WriteLine("What's your guess?");
                guess = Convert.ToDouble(Console.ReadLine());
                switch (guess)
                {
                    case 1:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    case 2:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    case 3:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    case 4:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    case 5:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    case 6:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    case 7:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    case 8:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    case 9:
                        Console.WriteLine("Nice try! you got it right!");
                        break;
                    case 10:
                        Console.WriteLine("Nice try, guess again!");
                        break;
                    default:
                        Console.WriteLine("Are you even trying?");
                        break;
                }
            }
            while (guess != number);
        }
    }
}

