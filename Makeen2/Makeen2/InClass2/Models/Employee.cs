using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass2.Models
{
    internal class Employee
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public double Wage { get; set; }
        public double Logged { get; set; }
        public Employee( string name, double wage, double logged)
        {
            Id +=1;
            Name = name;
            Wage = wage;
            Logged = logged;
        }

        public double CalculationGrowth()
        {
            return Wage * Logged;
        }

        public double CalculationNet()
        {
            double growth = Wage * Logged;
            return growth - (growth * 0.03);
        }
        public string GetInfo()
        {
            return Name+" the growth is : "+CalculationGrowth()+" the Net: "+CalculationNet();
        }

    }
}
