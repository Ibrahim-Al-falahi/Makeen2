using InClass1.Model;

namespace InClass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee(1,"Ahmed","Muscat","Manager",1500.5);
            Customer customer=new Customer(1, "Rami", "Suhar", 5);

            employee.SayHi();
            customer.SayHi();
        }
    }
}
