namespace Functional8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] seats = new char[5, 5];

            
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    seats[i, j] = 'A';

            int choice=0;

            while (choice != 5) 
            {
                Console.WriteLine("Movie Theatre Seat Booking");
                Console.WriteLine("1 View Seats");
                Console.WriteLine("2 Book Seat");
                Console.WriteLine("3 Cancel Booking");
                Console.WriteLine("4 Show Available Seat Count");
                Console.WriteLine("5 Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        Console.WriteLine("A : Available, X : Booked");

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write($"[{seats[i, j]}]");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2: 
                        Console.Write("Enter row (1-5): ");
                        int row = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Enter column (1-5): ");
                        int col = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (row < 0 || row >= 5 || col < 0 || col >= 5)
                        {
                            Console.WriteLine("Invalid");
                            break;
                        }

                        if (seats[row, col] == 'X')
                        {
                            Console.WriteLine("Already booked");
                        }
                        else
                        {
                            seats[row, col] = 'X';
                            Console.WriteLine("Booked");
                        }
                        break;

                    case 3: 
                        Console.Write("Enter row (1-5): ");
                        int cancelRow = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Enter column (1-5): ");
                        int cancelCol = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (cancelRow < 0 || cancelRow >= 5 || cancelCol < 0 || cancelCol >= 5)
                        {
                            Console.WriteLine("Invalid");
                            break;
                        }

                        if (seats[cancelRow, cancelCol] == 'A')
                        {
                            Console.WriteLine("Not booked");
                        }
                        else
                        {
                            seats[cancelRow, cancelCol] = 'A';
                            Console.WriteLine("Canceled");
                        }
                        break;

                    case 4:
                        int available = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (seats[i, j] == 'A')
                                {
                                    available++;
                                }
                            }
                        }

                        Console.WriteLine($"Available Seats: {available}");
                        break;

                    case 5:
                        Console.WriteLine("Bye");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } 
        }
    }
}
