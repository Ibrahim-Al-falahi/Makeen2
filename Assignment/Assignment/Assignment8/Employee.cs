using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Employee
    {

        public string Name { get; set; }
        private int salary;

        public int Salary
        {
            get { return salary; }
            set { 
                if (value>0)
                {

                salary = value;
                }
            }
        }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual double CalculateBonus()
        {
            return Salary * 0.1;
        }
    }
}
