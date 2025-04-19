namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //height of the Triangle
            int height = 5;
            //highest length of a row
            int length = height * 2 - 1;
            //empty spaces to make centerd Triangle
            string empty = new string(' ', height * 2);

            for (int i = 1; i <= length; i += 2)
            {

                //pivot is highest number in a row
                int pivot = i / 2 + 1;

                //value to print in each row
                int slotVal = 1;


                Console.Write(empty);

                empty = empty.Substring(0, empty.Length - 2);


                for (int j = 1; j <= i; j++)
                {
                    //if we reached highest number in a row now we need to divide last value by 2
                    // Eg: 16 8 4 2 1

                    if (j >= pivot && i != 1)
                    {
                        Console.Write(" " + slotVal);
                        slotVal /= 2;
                    }
                    //keep multiply last value by 2
                    // Eg: 1 2 4 8 16
                    else
                    {
                        Console.Write(" " + slotVal);
                        slotVal *= 2;
                    }

                }
                Console.WriteLine("");
            }
        }
    }
}
