using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the method in Class1 with t parameters, then doing it again but specifying parameters by name.
            Class1.method(5, 7);
            Class1.method(num1: 7, num2: 18);
            Console.Read();
        }
    }
}