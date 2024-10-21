using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "The quick";
            string string2 = "brown fox";
            string string3 = "jumped over";

            string concat = string1 + string2 + string3;
            concat = concat.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append(string1);
            sb.Append(string2);
            sb.Append(string3);

            Console.WriteLine(sb.ToString());
            Console.WriteLine(concat);
            Console.ReadLine();

             
        }
    }
}