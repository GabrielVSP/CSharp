using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex024
{
    internal class Product
    {

        private string name;
        private double price;
        private int quantity;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        override public string ToString()
        {
            return $"{this.name}, {this.price}";
        }
    }
}
