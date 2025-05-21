using System.Diagnostics.CodeAnalysis;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data type and variables
            //var number = -0;
            //var name = "Ahmed";

            //const double TAX = 3.5;// cannot redeclare

            //byte a = 1;
            //sbyte b = -2;
            //short s = -3;
            //ushort u = 4;
            //int i = -5;
            //uint j = 6;
            //long l = -7;
            //ulong ul = 8;
            //float f = -9;
            //double d = -10.5;
            //decimal c = 11;

            //char e = 'a';
            //bool isit = true;

            //string str = "Hi";
            //object o = null;
            //dynamic dy = true;
            //int[] arr = [1, 2, 3];  
            #endregion


            #region Interaction
            //string str = Console.ReadLine(); //take input from user
            //Console.WriteLine(str);// display input in console 
            #endregion

            #region Math operation
            //Console.WriteLine(5 + 5);
            //Console.WriteLine(5 - 5);
            //Console.WriteLine(5 * 5);
            //Console.WriteLine(5 / 5);
            //Console.WriteLine(5 % 5);
            //Console.WriteLine(5 ^ 2); 
            #endregion

            #region Increment
            //int x = 5;

            //Console.WriteLine(++x); //6
            //Console.WriteLine(x++); //6
            //Console.WriteLine(x); //7

            //Console.WriteLine(--x); //6
            //Console.WriteLine(x--); //6
            //Console.WriteLine(x); //5 
            #endregion

            #region Conditional
            //int y = 5;
            //if (y == 5)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (y != 5)
            //{
            //    Console.WriteLine(false);
            //}
            //else
            //{
            //    Console.WriteLine("wrong");
            //}

            //switch (y)
            //{
            //    case 5:
            //        Console.WriteLine(true);
            //        break;
            //    case 6:
            //        Console.WriteLine(false);
            //        break;
            //    default:
            //        Console.WriteLine("wrong");
            //        break;
            //} 
            #endregion

            #region Loop
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int x = 5;

            //while (x > 0)
            //{
            //    Console.WriteLine(x);
            //    x--;
            //}

            //do
            //{
            //    Console.WriteLine(x);
            //    x--;
            //}
            //while (x > 0); 
            #endregion

            check(5);//odd
            check(6); //even
        }
    public static void check(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else { Console.WriteLine("odd"); }
        }
    }
}
