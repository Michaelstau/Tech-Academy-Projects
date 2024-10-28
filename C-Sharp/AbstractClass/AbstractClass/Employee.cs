using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person

    // inherits from Person class, and Implements the SayName methos to print a string to the console.
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

}
