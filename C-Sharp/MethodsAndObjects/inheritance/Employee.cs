using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Employee : Person
    // inherits from Person class, and has an additional ID property.
    {
        public int ID { get; set; }
    }
}
