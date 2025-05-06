using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass3.Model
{
    internal class Report
    {
        public delegate bool TotalSales(Employee employee);


        public void Process(Employee[] emps, string title, TotalSales ts)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine(title);
                
            foreach (var employee in emps)
            {
                if (ts(employee))
                {
                    Console.WriteLine($"{employee.Name} has total sales : {employee.TotalSale}");
                }
            }
        }

        public void TotalSalesMoreThan60(Employee[] emps)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Total Sales more than 60");

            foreach (var employee in emps)
            {
                if (employee.TotalSale >= 60000)
                {
                    Console.WriteLine($"{employee.Name} has total sales : {employee.TotalSale}");
                }
            }
        }

        public void TotalSalesLessThan60(Employee[] emps)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Total Sales less than 60");

            foreach (var employee in emps)
            {
                if (employee.TotalSale >= 30000 && employee.TotalSale < 60000)
                {
                    Console.WriteLine($"{employee.Name} has total sales : {employee.TotalSale}");
                }
            }
        }

        public void TotalSalesLessThan30(Employee[] emps)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Total Sales less than 30");

            foreach (var employee in emps)
            {
                if (employee.TotalSale < 30000)
                {
                    Console.WriteLine($"{employee.Name} has total sales : {employee.TotalSale}");
                }
            }
        }
    }
}
