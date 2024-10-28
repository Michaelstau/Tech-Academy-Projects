using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        // instantiates an employee object, and calls the SayName method to print the employee's name to console. 
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", ID = 01};
            employee.SayName();
            Console.WriteLine();
        }
    }
}