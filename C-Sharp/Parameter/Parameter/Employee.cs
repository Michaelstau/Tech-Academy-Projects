using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    public class Employee<T> : Person

    // inherits from Person class
    // adds an Id property, and generic Things property
    // Implements the SayName method to print a string to the console
    {

        public List<T> Things { get; set; }
        public int Id { get; set; }
        public bool CurrentlyEmployed { get; set; }
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }


    }

}