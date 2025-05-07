namespace Functional5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] slots = new string[10];
            int choice=0;

            while (choice != 5)
            {
                Console.WriteLine("Parking Lot Menu");
                Console.WriteLine("1 Park a Car");
                Console.WriteLine("2 Remove a Car");
                Console.WriteLine("3 View All Slots");
                Console.WriteLine("4 Search for a Car");
                Console.WriteLine("5 Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        Console.Write("Enter car license number: ");
                        string license = Console.ReadLine();

                        
                        bool exists = false;
                        foreach (var car in slots)
                        {
                            if (car != null && car==license)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("This car is already parked.");
                            break;
                        }

                        
                        bool parked = false;
                        for (int i = 0; i < slots.Length; i++)
                        {
                            if (slots[i] == null)
                            {
                                slots[i] = license;
                                Console.WriteLine($"Car parked in slot {i + 1}");
                                parked = true;
                                break;
                            }
                        }

                        if (!parked)
                        {
                            Console.WriteLine("Full");
                        }
                        break;

                    case 2: 
                        Console.Write("Enter license number to remove: ");
                        string Remove = Console.ReadLine();
                        bool removed = false;

                        for (int i = 0; i < slots.Length; i++)
                        {
                            if (slots[i] != null && slots[i]==Remove)
                            {
                                slots[i] = null;
                                Console.WriteLine($"Car removed from slot {i + 1}");
                                removed = true;
                                break;
                            }
                        }

                        if (!removed)
                        {
                            Console.WriteLine("Car not found");
                        }
                        break;

                    case 3: 
                        Console.WriteLine("Parking Slots");
                        for (int i = 0; i < slots.Length; i++)
                        {
                            Console.WriteLine($"Slot {i + 1} : {slots[i]}");
                        }
                        break;

                    case 4: 
                        Console.Write("Enter license number to search: ");
                        string search = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < slots.Length; i++)
                        {
                            if (slots[i] != null && slots[i]==search)
                            {
                                Console.WriteLine($"Car found in slot {i + 1}");
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Car not found");
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
