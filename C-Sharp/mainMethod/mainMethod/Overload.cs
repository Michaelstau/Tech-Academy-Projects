using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethod
{
    class Overload
    {
        //method that takes int, adds 1 to it and returns it.
        public static int Overloaded(int num) 
        {
            int result = ++num;
            return result;
        }

        //method that takes float, doubles it, turns it into an int and returns it.
        public static int Overloaded(float num)
        {
            float result = num + num;
            return Convert.ToInt32(result);
        }

        //method that takes a string, converts it to an int if possible, squares it, and returns it.
        public static int Overloaded(string num)
        {
                int result = Convert.ToInt32(num);
                result = result * result;
                return result;
        }
    }
}
