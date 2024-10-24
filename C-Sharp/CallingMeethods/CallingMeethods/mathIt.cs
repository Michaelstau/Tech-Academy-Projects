using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMeethods
{
    public class mathIt
    {
        //three simple methods taking an int and returning it squares, doubled, or zeroed out.
        public static int squareIt(int num)
        {
            int solution = num * num;
            return solution;
        }
        public static int doubleIt(int num) 
        {
            int solution = num + num;
            return solution;
        }
        public static int zeroIt(int num) 
        {
            int solution = num * 0;
            return solution;
        }
    }
}
