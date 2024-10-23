using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Iterate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //instantiating an array of strings
            //asking for a phrase to add to each string
            //printing each edited string
            string[] fortunes = { 
                "You will soon receive an exciting proposal. ", 
                "Do unto others as you would have them do unto you. ", 
                "A faithful friend is a strong defense. ", 
                "A golden egg of opportunity falls into your lap this month. " 
            };
            Console.WriteLine("What would you like to add to your fortune cookie fortune?");
            string addOn = Console.ReadLine();
            for (int i = 0; i <fortunes.Length; i++)
            {
                fortunes[i] = fortunes[i] + addOn;
            }
            foreach (string fortune in fortunes)
            {
                Console.WriteLine(fortune);
            }

            //Part 2

            //changed "i--" to "i++" in line 38 to stop infinite loop.
            for (int i = 0; i < fortunes.Length; i++)
            {
                Console.WriteLine(i+1 + " fortunes: ahh, ahh, ahh!");
            }

            //Part 3
            // useing a < and <= comparison operator.
            for(int i = 0;i < fortunes.Length; i++)
            {
                Console.WriteLine("a line for each fortune, 0 to 3");
            }
            for (int i = 1; i <= fortunes.Length; i++)
            {
                Console.WriteLine("another line for each fortune, 1 to 4");
            }

            //Part 4 
            //instantiating a list
            //asking user for a line of text
            //looping throught the list to see if any items contain users text (and breaking if a match is found)
            //returning either matching items index (and item), or telling user their text didn't match any items.
            List<string> meals = new List<string> { 
            "Mac and cheese",
            "Fancy beet salad",
            "Cream of broccoli soup",
            "Ricecake with peanutbutter",
            "Baked potatoe"
            };
            Console.WriteLine("There's only a few things you can make for dinner tonight. if part of what you write matches a meal, that's what you get to eat.");
            bool hungry = true;
            string selection = Console.ReadLine();
            foreach (string meal in meals)
            {
                if (meal.Contains(selection))
                {
                    Console.WriteLine("You're having index item " + meals.IndexOf(meal) + ": " + meal);
                    hungry = false;
                    break;
                }
            }
            if (hungry)
            {
                Console.WriteLine("Your selection didn't match any of the available meals, please try again later.");
            }
            Console.ReadLine();

            //Part 5
            //instantiating a list with some duplicate items
            //asking user for a line of text
            //looping throught the list to see if any items contain users text
            //returning either matching items index (and item), or telling user their text didn't match any items.
            List<string> desserts = new List<string> {
            "Brownie",
            "Cheesecake",
            "Cinnamon roll",
            "Fudge",
            "Scone"
            };
            Console.WriteLine("There are sill desserts. if you can type a part of one of the desserts you can have one.");
            bool sweetTooth = true;
            string dessertSelection = Console.ReadLine();
            int dessertIndex = 0;
            foreach (string dessert in desserts)
            {
                if (dessert.Contains(dessertSelection))
                {
                    Console.WriteLine("Here, have a " + dessert + " item " + dessertIndex + " on the menu");
                    sweetTooth = false;
                }
                dessertIndex++;
            }
            if (sweetTooth)
            {
                Console.WriteLine("Sorry that didn't match any desserts, better luck next time.");
            }

            Console.ReadLine() ;
            Console.WriteLine("Time to clean up, hoere's the chores that need to be done:");
            //Part 6
            //instantiating a list with some duplicate items
            //Loop through the list and print out all items, and note if they've already been printed.
            List<string> chores = new List<string> {
                "put baby to bed",
                "do dishes",
                "put baby to bed",
                "clear table",
                "put baby to bed"
            };
            List<string> compare = new List<string>();
            foreach (string chore in chores)
            {
                if (compare.Contains(chore))
                {
                    Console.WriteLine(chore + " again");
                }
                else
                {
                    Console.WriteLine(chore);
                }
                compare.Add(chore);
            }
            Console.ReadLine();
        }
    }
}