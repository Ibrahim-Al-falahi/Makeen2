using InClass2.Models;

namespace InClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Salary Calculation program");
            //Console.WriteLine("please enter your logged hours: ");
            //double logged= double.Parse( Console.ReadLine());
            //Console.WriteLine("please enter your wage: ");
            //double wage= double.Parse(Console.ReadLine());


            //HelperFunction.CalculationGrowth(logged, wage);
            //double net = HelperFunction.CalculationNet(logged, wage);
            //Console.WriteLine("your net salary is : "+net);


            //Console.WriteLine("Enter number of employee : ");
            //int number = int.Parse(Console.ReadLine());

            //Employee[] List = new Employee[number];
            //Employee emp1 = new Employee("A", 5, 6);
            //Employee emp2 = new Employee("b", 5, 6);
            //Console.WriteLine(emp1.Id);
            //Console.WriteLine(emp2.Id);

            //int id = 1;

            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine("enter name, wage and logged");
            //    string name = Console.ReadLine();
            //    double logged = double.Parse(Console.ReadLine());
            //    double wage = double.Parse(Console.ReadLine());
            //    Employee emp=new Employee(id, name, logged, wage);
            //    id++;
            //}


            PhoneBook p = new PhoneBook(5);
            p[0, "yas"] = 96665;
            Console.WriteLine(p[0,"yas"]);
            //p.AddEntry(0, "Majan", 99223355);
            //p.AddEntry(1, "Mazoon", 77116633);

            //p.GetRecord(0);
            //p.GetRecord("Mazoon");

        }
    }
}
