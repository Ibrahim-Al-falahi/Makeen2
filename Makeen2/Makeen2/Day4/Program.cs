namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 5, 1, 7,5 }, { 4, 0, 9,1 }, { 8, 8, 2,7 }, { 1,2, 2, 3 } };

            int row_length= matrix.GetLength(0);
            int col_length= matrix.GetLength(1);

            int First_diagonal = 0;
            int Second_diagonal = 0;

            for (int i = 0; i < row_length; i++)
            {
                for (int j = 0; j < col_length; j++)
                {
                    if (i==j)
                    {
                        First_diagonal += matrix[i, j];
                    }

                    if (j==row_length-i-1)
                    {
                        Second_diagonal += matrix[i, j];
                    }
                }
            }
            int Result=First_diagonal-Second_diagonal;
            Console.WriteLine(" the result is "+First_diagonal +"-"+ Second_diagonal+ " the absolute number is "+Math.Abs(Result));
        }
    }
}
