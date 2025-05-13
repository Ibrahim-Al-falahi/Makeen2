using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyShop.Model
{
    internal class Catagory
    {
        public int CatagoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Product> products = new List<Product>();
    }
}
