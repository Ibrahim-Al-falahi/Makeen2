namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Rumor())
            {
                Console.WriteLine("Not Lying");
            }
            else
            {
                Console.WriteLine("Lying");
            }
        }
        public static bool Rumor()
        {
            int[] village = { 2, 3, 1 };

            for (int i = 0; i < village.Length; i++)
            {
                if (i + 1 == village[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
