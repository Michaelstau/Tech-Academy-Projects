using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args) 
        {
            int intAge = 0;
            bool success = false;
            while (!success) // while loop asking user for their age that continues until a valid int is given.
            {
                Console.WriteLine("How old are you?");
                var age = Console.ReadLine();
                success = int.TryParse(age, out intAge);
                if (!success)
                {
                    Console.WriteLine("Please enter only digits (without decimals).");
                }
            }
            try // Checks if age given is 0 or a negative number and throws a TooYoungException if so.
            {
                if (intAge < 1)
                {
                    throw new TooYoungException();
                }
            }
            catch (TooYoungException) // Prints message to user if TooYoung Exception is raised.
            {
                Console.WriteLine("Sorry this app isn't for time travelers and children under the age of 1.");
                Console.ReadLine();
                return;
            }
            catch (Exception) // A general message for other errors.
            {
                Console.WriteLine("Sorry something went wrong, ask a senior dev for help.");
            }
            int now = DateTime.Now.Year;
            Console.WriteLine("Looks like you were born in {0}, or maybe {1}", (now - intAge), (now - 1 - intAge));
        }
    }
}
