using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    class Program
    {
        static void Main(string[] args)
        //Creates two Employee objects with different Things types
        //Prints all things to console

        {

            Employee<string> employee1 = new Employee<string>()
            {
                FirstName = "Sample",
                LastName = "Student",
                CurrentlyEmployed = true,
                Id = 01,
                Things = new List<string>() { "One", "Two", "Three" }
            };

            Employee<int> employee2 = new Employee<int>()
            {
                FirstName = "Sample",
                LastName = "Student",
                CurrentlyEmployed = true,
                Id = 01,
                Things = new List<int>() { 1, 2, 3 }
            };
            

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Employee1, thing{i}: {employee1.Things[i]}, Employee2 thing{i}: {employee2.Things[i]}\n");
            }
            Console.ReadLine();
        }

    }
}