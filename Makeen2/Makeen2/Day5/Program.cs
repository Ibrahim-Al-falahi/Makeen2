namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 1, 1, 1 }; // [0]=north , [1]=west , [2]=south , [3]=east
            //int[] input = { 1, 2, 3, 4 }; //false
            //int[] input = { 4, 3, 2, 1 }; //false
            //int[] input = { 2, 1, 1, 2 }; //true


            if (input[0] >= input[2] && input[1] <= input[3])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
