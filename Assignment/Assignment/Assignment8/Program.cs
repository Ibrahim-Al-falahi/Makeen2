namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("E", 1500);
            Manager manager = new Manager("M", 3000);
            Developer developer = new Developer("D", 1000);

            HR hR = new HR();
            hR.employees.Add(employee);
            hR.employees.Add(manager);
            hR.employees.Add(developer);

            foreach (var item in hR.employees)
            {
                Console.WriteLine(item.CalculateBonus()); 
            }
        }
    }
}
