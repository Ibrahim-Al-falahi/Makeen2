namespace Home_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total_sale = 0;
            int revenue = 0;

            bool isValid=true;
            bool quit = true;

            Product p=new Product();
            List<Product> list = new List<Product>();

            while (isValid)
            {

                Console.WriteLine("Welcome to the Inventory Management System! \nPlease enter your username:");
                string user = Console.ReadLine();
                Console.WriteLine("Please enter your password: ");
                string pass = Console.ReadLine();

                if (user.ToLower() == "admin" && pass.ToLower() == "adminpass")
                {
                    while (quit)
                    {

                        Console.WriteLine("\n\n========================\nOptions:\r\n1. Add a new product\r\n2. Update product quantity\r\n3. Display product list\r\n4. Record sale\r\n5. Generate product report\r\n6. Generate sales report\r\n7. Exit\r\nSelect an operation (1-7):  ");
                        string option = Console.ReadLine();

                        switch (option)
                        {
                            case "1":
                                Console.WriteLine("Enter product name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter product price: ");
                                int price = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter product quantity: ");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                list.Add(p.addProduct(name, price, quantity));

                                break;
                            case "2":
                                Console.WriteLine("Enter product name: ");
                                string target = Console.ReadLine();
                                Console.WriteLine("Enter product quantity: ");
                                int uquantity = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in list)
                                {
                                    if (item.name == target)
                                    {
                                        item.updateQuantity(uquantity);
                                    }
                                }
                                break;
                            case "3":
                                foreach (var item in list)
                                {
                                    Console.WriteLine(item.toString()); 
                                }
                                break;
                            case "4":
                                Console.WriteLine("Enter product name: ");
                                string target_sale = Console.ReadLine();
                                Console.WriteLine("Enter product quantity: ");
                                int quantity_sale = Convert.ToInt32(Console.ReadLine());

                                foreach (var item in list)
                                {
                                    if (item.name == target_sale)
                                    {
                                        item.updateQuantity(item.quantity - quantity_sale);
                                        total_sale += quantity_sale;
                                        revenue += (quantity_sale * item.price);
                                    }
                                }
                                break;
                            case "5":
                                foreach (var item in list)
                                {
                                    Console.WriteLine(item.toString());
                                }
                                break;
                            case "6":
                                Console.WriteLine($"Sales Report:\r\nTotal Sales: {total_sale}\r\nTotal Revenue: {revenue}");
                                break;

                            case "7":
                                quit = false;
                                isValid = false;
                                break;



                            default:
                                Console.WriteLine("wrong input");
                                break;
                        }

                    }

                }
                else
                {
                    Console.WriteLine("invliad user name or password");
                }
            }
        }
    }
}
