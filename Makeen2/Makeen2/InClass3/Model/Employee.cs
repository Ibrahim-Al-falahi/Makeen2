using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass3.Model
{
    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int TotalSale { get; set; }
        public Employee(int id, string name, int salary, int totalSale)
        {
            Id = id;
            Name = name;
            Salary = salary;
            TotalSale = totalSale;
        }


    }
}
