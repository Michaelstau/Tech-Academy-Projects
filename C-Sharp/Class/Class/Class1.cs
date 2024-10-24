using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public static class Class1
    {
        static public void Method(int num, out int i)
            //take int num and int variable, and output result of num/2 to the variable.
        {
            i = num/2;
        }

        static public void Method(int num, out int i, int num2)
            //overload version of above with num/num2 instead of num/2
        {
            i = num / num2;
        }
    }
}
