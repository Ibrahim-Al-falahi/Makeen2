namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are "+Divide_Chocolate()+" to divide chocolate bar");
        }
        public static int Divide_Chocolate()
        {
            int[] s = { 4};
            int d = 4;
            int m = 1;
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int temp = 0;
                for (int j = i; j < s.Length; j++)
                {
                    if (j <i+m)
                    {
                        temp += s[j];
                    }
                }
                if (temp == d)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
