using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuitTable

    // inherits from Person class and IQuitTable interface
    //adds an Id property
    // Implements the SayName method to print a string to the console
    // implements Quit method from IQuitTable.
    {
        public int Id { get; set; }
        public bool CurrentlyEmployed { get; set; }
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
        public void Quit()
        {
            CurrentlyEmployed = false;
            Console.WriteLine($"{FirstName} {LastName} just quit.\nCurrentlyEmployed set to {CurrentlyEmployed}");
        }

        //Overloading both == and != operators to compare employees by Id
        public static bool operator== ( Employee a, Employee b )
        {
            bool result = a.Id == b.Id;
            return result;
        }
        public static bool operator!= (Employee a, Employee b)
        {
            bool result = a.Id != b.Id;
            return result;
        }

    }

}
