using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Car: Vehicle
    {

        public int NumberOfDoors { get; set; }
        public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo()+ " NumberOfDoors: " + NumberOfDoors;
        }
    }
}
