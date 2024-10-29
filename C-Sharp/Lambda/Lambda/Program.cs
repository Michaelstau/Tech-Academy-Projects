using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating a list of Employee objects
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 01, FirstName = "Sean", LastName = "Hungry" },
                new Employee { Id = 02, FirstName = "Ann", LastName = "Smith" },
                new Employee { Id = 03, FirstName = "Joe", LastName = "Ryans" },
                new Employee { Id = 04, FirstName = "Sara", LastName = "Gathers" },
                new Employee { Id = 05, FirstName = "Finley", LastName = "Hunter" },
                new Employee { Id = 06, FirstName = "Bex", LastName = "Smith" },
                new Employee { Id = 07, FirstName = "Sue", LastName = "Winer" },
                new Employee { Id = 08, FirstName = "Jim", LastName = "Shook" },
                new Employee { Id = 09, FirstName = "Joe", LastName = "Driver" },
                new Employee { Id = 10, FirstName = "Tess", LastName = "Harris" }
            };

            //Making a Joes list, and using a for loop to populate it with all employees with first name Joe.
            List<Employee> Joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Joes.Add(employee);
                }
            }

            //Using a lambda function to populate a list with all employees with first name joe.
            List<Employee> LamJoes = employees.Where(x => x.FirstName == "Joe").ToList();
            //Using a lambda function to populate a list with all employees with Id value greater than 5.
            List<Employee> Over5 = employees.Where(x => x.Id > 5).ToList();
        }
    }
}