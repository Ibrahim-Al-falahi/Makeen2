using System.Security.Cryptography;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s = 7;
            int t = 10;
            int a = 4;
            int b = 12;
            int[] m = { 2, 3, -4 };
            int[] n = { 3, -2, -4 };

            //int s = 7;
            //int t = 11;
            //int a = 5;
            //int b = 15;
            //int[] m = { -2, 2, 1 };
            //int[] n = { 5, -6 };

            int apple = 0;
            int orange = 0;

            for (int i = 0; i < m.Length; i++)
            {
                if ((m[i]+a)>=s && (m[i] + a) <= t)
                {
                    apple++;
                }
            }
            for (int i = 0;i < n.Length; i++)
            {
                if ((n[i] + b) >= s && (n[i] + b) <= t)
                {
                    orange++;
                }
            }

            Console.WriteLine(apple+" Apple and "+orange+" Orange has fallen in the house");

        }
    }
}
