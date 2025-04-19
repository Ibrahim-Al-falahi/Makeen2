using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<int> number = new List<int>() { 1, 2, 1, 3, 4, 2, 4, 4 };

            int count = 0;

            //get max value from the list
            int max = number.Max();
            //sort the list Desc
            number.Sort((a, b) => b.CompareTo(a));

            for (int i = 0; i < number.Count; i++)
            {
                //since we have Desc order of the list we can count highest numbers first and ignore the rest of it, and break the loop of faster results
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
