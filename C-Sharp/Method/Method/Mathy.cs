using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Mathy
    { 
        public static int Add(int x, int y = 3)
        {
            int result = x + y;
            return result;
        }
    }
}
