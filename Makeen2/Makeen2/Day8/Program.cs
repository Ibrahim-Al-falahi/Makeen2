namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check());
        }

        public static string Check()
        {
            //Qusai
            //int x=1; int y=20;
            //int[] from = { 1, 4, 10 };
            //int[] to = { 5, 15, 20 };

            //Qusai
            int x = 5; int y = 12;
            int[] from = { 8, 10, 7 };
            int[] to = { 10, 12, 8 };



            for (int i = x; i < y; i++)
            {
                int counter = 0;
                for (int j = 0; j < from.Length; j++)
                {
                    if (i >= from[j] && i <= to[j])
                    {
                        counter++;
                    }
                    
                }
                if (counter==0)
                {
                    return "NO";
                }

            }
            return "YES";
        }
    }
}
