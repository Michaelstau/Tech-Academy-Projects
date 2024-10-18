
namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is your package weight?");

            //Prompt user to input a weight, if input is greater than 50, display a message and exit program.
            float weight = Convert.ToSingle(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);
            }

            //Prompt user to input 3 dimensional values, if their sum is greater that 50, display a message and exit program.
            Console.WriteLine("What is your package width?");
            float width = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("What is your package length?");
            float length = Convert.ToSingle(Console.ReadLine());
            if (length + width + height > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);
            }

            //multiply the three dimensions (to get volume) by the weight and divide by 100 and round up to 2 decimals.
            //display this number with a message as the quote to ship a package.
            double quote = Math.Round((double)length * (double)width * (double)height * (double)weight / (double)100, 2);
            Console.WriteLine("Your package will cost $" + quote + " to ship.");
        }
    }
}