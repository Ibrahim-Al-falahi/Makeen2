using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<int> number = new List<int>() { 1, 2, 1, 3, 4, 2, 4, 4 };

            int count = 0;

            int max = number.Max();
            number.Sort((a, b) => b.CompareTo(a));

            for (int i = 0; i < number.Count; i++)
            {
                if (max == number[i])
                {
                    count++;
                }
                else { break; }


            }

            Console.WriteLine("the max number is " + max + " and they are only " + count);
        }
    }
}
