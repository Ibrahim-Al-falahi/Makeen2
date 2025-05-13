using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyShop.Model
{
    internal class Product
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public bool HasDiscount { get; set; }

        [ForeignKey("CatagoryId")]
        public Catagory Catagory { get; set; }
        public int CatagoryId { get; set; }



        public List<Tag> tags = new List<Tag>();
    }
}
