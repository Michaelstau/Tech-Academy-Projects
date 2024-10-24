using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    internal class Class1
    {
        //method that takes 2 parameters, adds 3 to the 1st, and prints the 2nd
        public static void method(int num1, int num2)
        {
            num1 = num1 + 3;
            Console.WriteLine(num2);
        }
    }
}
