using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region check string
            //string name = Console.ReadLine();
            //string result = name != "" ? name : "Null";

            //Console.WriteLine("the name is " + result); 
            #endregion

            //int x = 3;
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(++x);



            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 0)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("This Negitive number");
            //}


            //bool gusse = true;
            //int num = 10;


            //while (gusse)
            //{
            //    Console.WriteLine("Ready? ( Y / N )");
            //    string quit = Console.ReadLine();
            //    //Console.WriteLine(quit);
            //    if (quit == "y")
            //    {
            //        Console.WriteLine("Type number");
            //        int your = Convert.ToInt32(Console.ReadLine());

            //        if (num > your)
            //        {
            //            Console.WriteLine("Up");
            //        }
            //        else if (num < your)
            //        {
            //            Console.WriteLine("Down");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Right Congratz");
            //            gusse = false;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("See u next time");
            //        gusse = false;
            //    }
            //}


            //int input= Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //while (input!=0)
            //{

            //    //sum= 0 , 3 , 5 , 6
            //    sum += input % 10;

            //    // input 123 , 12 , 1 , 0
            //    input /= 10;
            //}
            //Console.WriteLine(sum);



            //Console.Write("Welcome to the Coffee Shop \n Menu: \n 1.Americano - 2.50 \n 2.Latte - 3.00 \n 3.Cappuccino - 3.50 \n Select a coffee (1-3): ");
            //string coffee_type=Console.ReadLine();


            //string result = "";
            //double price = 0;

            //switch (coffee_type)
            //{
            //    case "1":
            //        result = "Americano "; price = 2.5;
            //        break;
            //    case "2":
            //        result = "Latte "; price = 3.0;
            //        break;
            //    case "3":
            //        result = "Cappuccino "; price = 3.5;
            //        break;

            //    default:
            //        Console.WriteLine("wrong number");
            //        break;

            //}

            //Console.Write("Customizations: \n 1.Small \n 2.Medium \n 3.Large\n Select a size (1-3): ");

            //string size = Console.ReadLine();


            //switch (size)
            //{
            //    case "1":
            //        result += "(Small) "; 
            //        break;
            //    case "2":
            //        result += "(Medium) "; 
            //        break;
            //    case "3":
            //        result += "(Large) ";
            //        break;

            //    default:
            //        Console.WriteLine("wrong number");
            //        break;

            //}

            //Console.Write("Do you want sugar? (yes/no): ");
            //string sugar = Console.ReadLine();

            //if (sugar=="yes")
            //{
            //    result += "with sugar ";
            //}

            //Console.Write("Do you want milk? (yes/no): ");
            //string milk = Console.ReadLine();

            //if (milk == "yes")
            //{
            //    result += "and milk ";
            //}

            //Console.Write("Your Order Summary: "+result+ " \n Total Cost: "+price+ "\n Thank you for ordering!");



            //for (int i = 1; i <= 100; i++)
            //{
            //    int sum = 0;

            //    for (int j = 1; j < i; j++)
            //    {
            //        if (i%j==0)
            //        {
            //            sum += j;
            //        }
            //    }
            //    if (sum==i)
            //    {
            //        Console.WriteLine("this is prefect number: "+i);
            //    }

            //}

            //int a = 100;
            //bool b = true;

            //static void Withdraw(ref int number)
            //{
            //    number -= 5;
            //}

            //static void Transfare(ref int number)
            //{
            //    number -= 10;
            //}

            //while (b)
            //{
            //    Console.WriteLine("Choose \n 1-Check amount \n 2-Withdraw \n 3-Transfare");
            //    string input = Console.ReadLine();

            //    switch (input)
            //    {
            //        case "1":
            //            Console.WriteLine(a);
            //            break;
            //        case "2":
            //            Withdraw(ref a);
            //            Console.WriteLine(a);
            //            break;
            //        case "3":
            //            Transfare(ref a);
            //            Console.WriteLine(a);
            //            break;
            //        default:
            //            b = false;
            //            break;
            //    }
            //}

            //Rectangle r = new Rectangle(5, 6, "Red");

            //r.area();
            //r.getInfo();

            //Coffee coffee = new Coffee();

            //coffee.display_menu();
            //coffee.display_order_summary();


            //string[] usernames = { "ahmed", "yaser", "muzna" };
            //string[] passwords = { "ah123", "ya123", "mu123" };
            //double[] balances = { 1000.0, 500.0, 750.0 };

            //bool IsValid = true;
            //int index = 0;

            //Console.WriteLine("Welcome to Simple Bank ");

            //// Login loop
            //while (IsValid)
            //{
            //    Console.Write("Enter username: ");
            //    string inputUser = Console.ReadLine();
            //    Console.Write("Enter password: ");
            //    string inputPass = Console.ReadLine();

            //    for (int i = 0; i < usernames.Length; i++)
            //    {
            //        if (usernames[i] == inputUser && passwords[i] == inputPass)
            //        {
            //            index = i;

            //            int choice;
            //            do
            //            {
            //                Console.WriteLine("\n Main Menu ");
            //                Console.WriteLine("1) Check Balance");
            //                Console.WriteLine("2) Deposit");
            //                Console.WriteLine("3) Withdraw");
            //                Console.WriteLine("4) Transfer");
            //                Console.WriteLine("5) Exit");
            //                Console.WriteLine("Enter your choice: ");

            //                choice = int.Parse(Console.ReadLine());


            //                switch (choice)
            //                {
            //                    case 1:
            //                        Console.WriteLine("Your balance is: $" + balances[index]);
            //                        break;

            //                    case 2:
            //                        Console.Write("Enter amount to deposit: ");
            //                        double deposit = double.Parse(Console.ReadLine());
            //                        if (deposit > 0)
            //                        {
            //                            balances[index] += deposit;
            //                            Console.WriteLine("Deposited successfully.");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Invalid amount.");
            //                        }
            //                        break;

            //                    case 3:
            //                        Console.Write("Enter amount to withdraw: ");
            //                        double withdraw = double.Parse(Console.ReadLine());
            //                        if ( withdraw > 0)
            //                        {
            //                            if (withdraw <= balances[index])
            //                            {
            //                                balances[index] -= withdraw;
            //                                Console.WriteLine("Withdrawn successfully.");
            //                            }
            //                            else
            //                            {
            //                                Console.WriteLine("Insufficient funds.");
            //                            }
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Invalid amount.");
            //                        }
            //                        break;

            //                    case 4:
            //                        Console.Write("Enter amount to transfer: ");
            //                        double transfer = double.Parse(Console.ReadLine());
            //                        if ( transfer > 0)
            //                        {
            //                            if (transfer <= balances[index])
            //                            {
            //                                balances[index] -= transfer;
            //                                Console.WriteLine("Transfer successfully.");
            //                            }
            //                            else
            //                            {
            //                                Console.WriteLine("Insufficient funds.");
            //                            }
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Invalid amount.");
            //                        }
            //                        break;

            //                    case 5:
            //                        Console.WriteLine("Thank you for using Simple Bank!");
            //                        IsValid = false;
            //                        break;

            //                    default:
            //                        Console.WriteLine("Invalid choice. Try again.");
            //                        break;
            //                }

            //            } while (choice != 5);

            //            break;
            //        }

            //    }
            //    if (IsValid)
            //    {
            //        Console.WriteLine("Invalid username or password. Try again.\n");
            //    }


            //}

            //string[] product = { "cable", "laptop", "camera" };
            //int[] quantity = { 5, 13, 2 };
            //bool quit=true;

            //string target;
            //int uquantity;

            //while (quit)
            //{

            //    Console.WriteLine("\n\n========================\nOptions:\r\n1. View All Products\r\n2. Add Stock\r\n3. Sell Product\r\n4. Check Product Quantity\r\n5. Exit");
            //    string option = Console.ReadLine();

            //    if (option == "1")
            //    {
            //        for (int i = 0; i < product.Length; i++)
            //        {
            //            Console.WriteLine(product[i]);
            //        }
            //    }else if (option == "2")
            //    {
            //        Console.WriteLine("Enter product name: ");
            //        target = Console.ReadLine();
            //        Console.WriteLine("Enter product quantity: ");
            //        uquantity = Convert.ToInt32(Console.ReadLine());

            //        for (int i = 0; i < product.Length; i++)
            //        {
            //            if (product[i] == target)
            //            {
            //                quantity[i] += uquantity;
            //            }
            //        }
            //    }
            //    else if (option == "3")
            //    {
            //        Console.WriteLine("Enter product name: ");
            //        target = Console.ReadLine();
            //        Console.WriteLine("Enter product quantity: ");
            //        uquantity = Convert.ToInt32(Console.ReadLine());

            //        for (int i = 0; i < product.Length; i++)
            //        {
            //            if (product[i] == target)
            //            {
            //                quantity[i] -= uquantity;
            //            }
            //        }
            //    }
            //    else if (option == "4")
            //    {
            //        Console.WriteLine("Enter product name: ");
            //        target = Console.ReadLine();

            //        for (int i = 0; i < product.Length; i++)
            //        {
            //            if (product[i] == target)
            //            {
            //                Console.WriteLine(quantity[i]);
            //            }
                        
            //        }
            //    }
            //    else
            //    {
            //        quit = false;
            //    }

                

            //}


        }
    }

    //public class Rectangle
    //{

    //    public int width;
    //    public int height;
    //    public string color;

    //    public Rectangle(int width, int height, string color)
    //    {
    //        this.width = width;
    //        this.height = height;
    //        this.color = color;
    //    }
    //    public void area()
    //    {
    //        Console.WriteLine( width * height);
            
    //    }
        
    //    public void getInfo()
    //    {
    //        Console.WriteLine("this a "+color+ " Rectangle");
    //    }
    //}

    //public interface Ipay
    //{
    //    public bool pay();
    //}
    //class Coffee
    //{
    //    public string name { get; set; }
    //    public string size { get; set; }
    //    public double price { get; set; }
    //    public string Milk { get; set; }
    //    public string Sugar { get; set; }

    //    public Coffee()
    //    {
            
    //    }

        

    //    public void display_menu()
    //    {
    //        Console.Write("Welcome to the Coffee Shop \n Menu: \n 1.Americano - 2.50 \n 2.Latte - 3.00 \n 3.Cappuccino - 3.50 \n ");
    //        Console.Write("\nCustomizations: \n 1.Small - 0.50\n 2.Medium - 1.00 \n 3.Large - 1.50\n  ");
    //    }
    //    public string place_order()
    //    {
    //        string result = "";

    //        Console.Write("\nWhich Coffee do you want? (1-3): ");
    //        string coffee_input = Console.ReadLine();

    //        if (coffee_input == "1")
    //        {
    //            name = "Americano";
                
    //        }
    //        else if (coffee_input == "2")
    //        {
    //            name = "Latte";
    //        }
    //        else
    //        {
    //            name = "Cappuccino";
    //        }
    //        result += name;

    //        Console.Write("\nWhich size would you like? (1-3): ");
    //        string size_input = Console.ReadLine();

    //        if (size_input == "1")
    //        {
    //            size = "S";
    //        }
    //        else if (size_input == "2")
    //        {
    //            size = "M";
    //        }
    //        else
    //        {
    //            size = "L";
    //        }
    //        result += " ("+size+") size ";

    //        Console.Write("\nDo you want sugar? (yes/no): ");
    //        Sugar = Console.ReadLine();

    //        if (Sugar.ToLower() == "yes")
    //        {
    //            result += "with sugar ";
    //        }

    //        Console.Write("\nDo you want milk? (yes/no): ");
    //        Milk = Console.ReadLine();

    //        if (Milk.ToLower() == "yes")
    //        {
    //            result += "and milk ";
    //        }
    //        return result;
    //    }
    //    public double calculate_cost()
    //    {
    //        if(name== "Americano")
    //        {
    //            price = 2.5;
    //        }
    //        else if(name== "Latte")
    //        {
    //            price = 3.0;
    //        }
    //        else
    //        {
    //            price = 3.5;
    //        }

    //        if (size == "L")
    //        {
    //            price += 1.5;
    //        }
    //        else if (size == "M")
    //        {
    //            price += 1.0;
    //        }
    //        else
    //        {
    //            price += 0.5;
    //        }
    //        return price;
    //    }
    //    public void display_order_summary()
    //    {
    //        Console.Write("\nYour Order Summary: " + place_order() + " \n Total Cost: " + calculate_cost() + "\n Thank you for ordering!");
    //    }

        
    //}
}
