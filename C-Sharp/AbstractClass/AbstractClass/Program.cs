using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        //creates an employee object
        //calls SayName to print a string with name properties to console

        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", CurrentlyEmployed = true, Id = 01 };
            employee.SayName();

            //creates IQuiteTable object, and calls Quit on it
            //calls Quit on 2nd employee
            IQuitTable employee2 = new Employee() { FirstName = "Test", LastName = "Hire", CurrentlyEmployed = true, Id = 02 };
            employee2.Quit();

        //Creates 2nd employee object and uses overloaded comparison operator to compare it to 1st employee object.
            Employee employee3 = new Employee() { FirstName = "Michael", LastName = "Stauber", CurrentlyEmployed = true, Id = 03 };
            Console.WriteLine($"Checking if {employee.FirstName} {employee.LastName} and {employee3.FirstName} {employee3.LastName} have same id: ... ");
            Console.WriteLine(employee == employee3);
            Console.ReadLine();
        }

        //creates an IQuitTable object with properties, and then calls Quit to print a string with those properties to console ().
    }
}