using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Truck:Vehicle
    {

        public int LoadCapacity { get; set; }
        public Truck(string make, string model, int year, int loadCapacity) : base(make, model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " LoadCapacity: " + LoadCapacity;
        }
    }
}
