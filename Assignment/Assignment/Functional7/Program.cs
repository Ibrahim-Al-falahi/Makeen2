namespace Functional7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books = {
            "Apple",
            "Orange",
            "Banana",
            "Melon",
            "Kiwi"
        };

            bool[] isBorrowed = new bool[books.Length];

            int choice = 0;

            while (choice != 5) 
            {
                Console.WriteLine("Library Menu");
                Console.WriteLine("1 View Books");
                Console.WriteLine("2 Borrow Book");
                Console.WriteLine("3 Return Book");
                Console.WriteLine("4 Check Availability");
                Console.WriteLine("5 Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        Console.WriteLine("Book List");
                        for (int i = 0; i < books.Length; i++)
                        {
                            string status = isBorrowed[i] ? "Borrowed" : "Available";
                            Console.WriteLine($"{books[i]} : {status}");
                        }
                        break;

                    case 2: 
                        Console.Write("Enter book number to borrow: ");
                        int borrowIndex = int.Parse(Console.ReadLine());
                        if (borrowIndex >= 1 && borrowIndex <= books.Length)
                        {
                            if (isBorrowed[borrowIndex - 1])
                            {
                                Console.WriteLine("Already borrowed");
                            }
                            else
                            {
                                isBorrowed[borrowIndex - 1] = true;
                                Console.WriteLine("Borrowed");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;

                    case 3: 
                        Console.Write("Enter book number to return: ");
                        int returnIndex = int.Parse(Console.ReadLine());
                        if (returnIndex >= 1 && returnIndex <= books.Length)
                        {
                            if (!isBorrowed[returnIndex - 1])
                            {
                                Console.WriteLine("Not borrowed");
                            }
                            else
                            {
                                isBorrowed[returnIndex - 1] = false;
                                Console.WriteLine("Book returned");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;

                    case 4: 
                        Console.Write("Enter book number to check availability: ");
                        int checkIndex = int.Parse(Console.ReadLine());
                        if (checkIndex >= 1 && checkIndex <= books.Length)
                        {
                            string status = isBorrowed[checkIndex - 1] ? "Not Available" : "Available";
                            Console.WriteLine($"{books[checkIndex - 1]} : {status}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
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
