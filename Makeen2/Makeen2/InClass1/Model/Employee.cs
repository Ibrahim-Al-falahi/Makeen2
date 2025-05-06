using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1.Model
{
    internal class Employee:User
    {

        public string Title { get; set; }
        public double Salary { get; set; }
        public Employee(int Id, string Name, string City, string Title, double Salary) : base(Id, Name, City)
        {
            this.Title = Title;
            this.Salary = Salary;
        }

        public override void SayHi()
        {
            Console.WriteLine("I'm Employee OMG");
        }
    }
}
