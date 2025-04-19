namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int black = 10;
            int white = 10;

            int height = 0;

            for (int i = 1; i < 100; i++)
            {
                //check if its odd or even number
                // if True then it is even number
                if ((i % 2) == 0)
                {
                    //check if there is enough balls
                    if (black >= i)
                    {
                        black = black - i;
                        height++;

                    }
                    else { break; }
                }
                else
                {
                    //check if there is enough balls
                    if (white >= i)
                    {
                        white = white - i;
                        height++;
                    }
                    else { break; }
                }
            }

            Console.WriteLine("the hight is " + height);
        }
    }
}
