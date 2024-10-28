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
        //creates 2nd employee object of type IQuiteTable
        //calls Quit on 2nd employee
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", CurrentlyEmployed = true };
            employee.SayName();

            IQuitTable employee2 = new Employee() { FirstName = "Test", LastName = "Hire", CurrentlyEmployed = true };
            employee2.Quit();
            Console.ReadLine();
        }

        //creates an IQuitTable object with properties, and then calls Quit to print a string with those properties to console ().
    }
}