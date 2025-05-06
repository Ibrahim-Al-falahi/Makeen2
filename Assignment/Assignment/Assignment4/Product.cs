using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Product
    {

        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
        }

        public Product(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int CalculateTotal()
        {
            return Price*Quantity;
        }

        public int CalculateTotal(int price, int quantity)
        {
            return price * quantity;
        }





    }
}
