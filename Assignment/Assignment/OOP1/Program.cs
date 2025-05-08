namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketSystem system = new TicketSystem();

            system[""] =(new Ticket("Concert A", "A12", TicketType.Regular));
            system[""]=(new Ticket("Concert A", "B15", TicketType.VIP));
            system[""]=(new Ticket("Concert B", "C7", TicketType.Backstage));
            system[""]=(new Ticket("Concert A", "A13", TicketType.Regular));
            system[""]=(new Ticket("Concert B", "D20", TicketType.VIP));

            Console.WriteLine("Accessing Tickets by Seat Number");
            Console.WriteLine(system["A12"]);
            Console.WriteLine(system["B15"]);
            Console.WriteLine(system["C7"]);
            Console.WriteLine(system["A99"]); 

            Console.WriteLine("Ticket Count by Type");
            system.CountTicketsByType();
        }
    }
}
