namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product product = new Product("pc",600,6);
            Product product1 = new Product("laptop", 300, 10);
            Product product2 = new Product("camera", 100, 3);

            Order order = new Order();
            order.AddProduct(product);
            order.AddProduct(product1);
            order.AddProduct(product2);

            Console.WriteLine( order.CalculateTotalCost());

        }
    }
}
