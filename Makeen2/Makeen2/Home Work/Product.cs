using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    internal class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }


        public Product()
        {
            
        }
        public Product(string name, int price,int quantity)
        {
            this.name = name;
            this.price = price; 
            this.quantity = quantity;
        }

        public Product addProduct(string name,int price,int quantity)
        {
            Product product= new Product(name, price,quantity);
            Console.WriteLine("product added successfully");
            return product;
        }
        public int updateQuantity(int quantity)
        {

            this.quantity = quantity;
            return this.quantity;
        }
        public string toString()
        {
            return $"{name} - Price: {price}, Quantity: {quantity}";
        }

    }
}
