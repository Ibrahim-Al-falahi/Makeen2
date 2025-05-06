using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1.Model
{
    internal class Customer : User
    {
        public int NumberOfProduct { get; set; }
        public Customer(int Id, string Name, string City, int numberOfProduct) : base(Id, Name, City)
        {
            NumberOfProduct = numberOfProduct;
        }

        public override void SayHi()
        {
            Console.WriteLine("Hi I'm poor cuxtomer");
        }
    }
}
