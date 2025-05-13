using CodeAcademyShop.Context;
using CodeAcademyShop.Model;

namespace CodeAcademyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            Product product = new Product()
            {
                Name= "PC",
                Description="Gaming Device",
                Quantity = 1,
                Price = 1,
                HasDiscount=true,
                CatagoryId=1
            };

            Catagory catagory = new Catagory()
            {
                Name = "PC",
                Description = "Gaming Device"
            };


            //db.Add(catagory);
            //db.Add(product);

            //db.SaveChanges();


            //var prod=(from p in db.Product
            //          where p.ProductId ==1
            //          select p).FirstOrDefault();

            //prod.Price = 300;


            //db.Product.Update(prod);
            //db.SaveChanges();


            //db.Product.Remove(prod);
            //db.SaveChanges();

        }
    }
}
