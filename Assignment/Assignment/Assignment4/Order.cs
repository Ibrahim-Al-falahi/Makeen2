using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Order
    {
        List<Product> products;

        public Order()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public int CalculateTotalCost()
        {
            int totalCost = 0;
            foreach (var p in products)
            {
                totalCost += p.CalculateTotal();
            }
            return totalCost;
        }
    }
}
