using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Order
    {
        public Order(string coffee) : this (coffee, "Medium" )
        { }
        public Order(string coffee, string size)
        { 
            Coffee = coffee;
            Size = size;
            Drink = ($"Your {Size}, {Coffee} has been constructed, and is on the bar.");
        }
        public string Coffee {  get; set; }
        public string Size { get; set; }
        public string Drink { get; set; }
    }
}
