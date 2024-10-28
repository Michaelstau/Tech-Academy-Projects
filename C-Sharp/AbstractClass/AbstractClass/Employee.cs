using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuitTable

    // inherits from Person class and IQuitTable interface
    // Implements the SayName method to print a string to the console
    // implements Quit method from IQuitTable.
    {
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
    }

}
