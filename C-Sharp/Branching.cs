
namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is your package weight?");
            float weight = Convert.ToSingle(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);
            }
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
            double quote = Math.Round((double)length * (double)width * (double)height * (double)weight / (double)100, 2);
            Console.WriteLine("Your package will cost $" + quote.ToString("F") + " to ship.");
        }
    }
}