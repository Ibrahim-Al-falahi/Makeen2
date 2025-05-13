using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyShop.Model
{
    internal class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public List<Product> products = new List<Product>();

    }
}
