namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] x = { 2, 1, 1, 2 }; //[x1,v1,x2,v2]
            //int[] x = { 0, 3, 4, 2 }; //[x1,v1,x2,v2]
            int[] x = { 0, 2, 5, 3 }; //[x1,v1,x2,v2]
            Console.WriteLine(check(x)); 


        }

        public static string check(int[] x) {

            int k1 = x[0];
            int k2 = x[2];

            for (int i = 1; i < 100; i++)
            {
                k1 += x[1];
                k2 += x[3];

                if (k1 == k2)
                {
                    return "YES";
                }
            }
            return "NO";
        }

    }
    
}
