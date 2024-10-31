using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        //greets user, requests two strings of user input, and makes an Order object using one, or both strings.
        //then returns a message based on results.
        {
            const string shop = "Coffeeopolis";
            Console.WriteLine("Welcome to {0} What kind of coffee would you like?", shop);
            var coffee = Console.ReadLine();
            Console.WriteLine("What size?");
            var size = Console.ReadLine();
            if (size.ToLower() == "large" || size.ToLower() == "medium" || size.ToLower() == "small")
            
            {
                Order drink = new Order(coffee, size);
                Console.WriteLine(drink.Drink);
                Console.ReadLine();
            }
            else
            {
                Order drink = new Order(coffee);
                Console.WriteLine(drink.Drink);
                Console.ReadLine();
            }

        }
    }
}