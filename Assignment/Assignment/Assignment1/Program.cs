namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("A", "Maya", 2009);
            Book b2 = new Book("B", "Lara", 1999);
            Book b3 = new Book("B", "Sophia", 1989);

            b1.PrintBookInfo();
            b2.PrintBookInfo();
            b3.PrintBookInfo();

            Console.WriteLine(b1.check(2008));
            Console.WriteLine(b2.check(2008));
            Console.WriteLine(b3.check(1888));

        }
    }
}
