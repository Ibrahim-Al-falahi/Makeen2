using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    internal class Baggage
    {
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public double Weight { get; set; }
        public int TrackingNumber { get; set; }
    }
}
