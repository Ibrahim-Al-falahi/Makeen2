namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string name = Console.ReadLine();
            //string result = name != "" ? name : "Null";

            //Console.WriteLine("the name is " + result);

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


            bool gusse = true;
            int num = 10;


            while (gusse)
            {
                Console.WriteLine("Ready? ( Y / N )");
                string quit = Console.ReadLine();
                //Console.WriteLine(quit);
                if (quit == "y")
                {
                    Console.WriteLine("Type number");
                    int your = Convert.ToInt32(Console.ReadLine());

                    if (num > your)
                    {
                        Console.WriteLine("Up");
                    }
                    else if (num < your)
                    {
                        Console.WriteLine("Down");
                    }
                    else
                    {
                        Console.WriteLine("Right Congratz");
                        gusse = false;
                    }
                }
                else
                {
                    Console.WriteLine("See u next time");
                    gusse = false;
                }
            }



        }
    }
}
