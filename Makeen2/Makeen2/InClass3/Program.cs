using InClass3.Model;

namespace InClass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            //Employee[] employees = new Employee[]
            //    {
            //    new Employee(1,"A",2000,80000),
            //    new Employee(2,"B",1500,100000),
            //    new Employee(3,"C",2500,50000),
            //    new Employee(4,"D",4000,20000),
            //    new Employee(5,"E",6000,60000)
            //    };

            //Report report = new Report();

            ////report.TotalSalesLessThan30(employees);
            ////report.TotalSalesLessThan60(employees);   
            ////report.TotalSalesMoreThan60(employees);

            //report.Process(employees, "Total Sales more than 60", MoreThan60);
            //report.Process(employees, "Total Sales between 60 and 30", Between60And30);
            //report.Process(employees, "Total Sales less than 30", LessThan30);


            //bool MoreThan60(Employee emp) => emp.TotalSale >= 60000;
            //bool Between60And30(Employee emp) => emp.TotalSale >= 30000 && emp.TotalSale < 60000;
            //bool LessThan30(Employee emp) => emp.TotalSale < 30000;
            #endregion


            Money m1 = new Money(10);
            Money m2 = new Money(20);

            Money m3=m1+ m2;
            Console.WriteLine(m3.Amount);
            Money m4 = m1-m2;
            Console.WriteLine(m4.Amount);

            Console.WriteLine(m1>m2);
            Console.WriteLine(m1 < m2);
        }
    }
}
