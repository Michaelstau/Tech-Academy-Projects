using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling three methods of overload, and printing results.
            Console.WriteLine(Overload.Overloaded(2));
            Console.WriteLine(Overload.Overloaded((float)2.64));
            Console.WriteLine(Overload.Overloaded("two"));
        }
    }
}