using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Controller
    {
        public void Run(IDevice device)
        {
            device.TurnOn();
            Console.WriteLine(device.ShowStatus()); 
            device.TurnOff();
            Console.WriteLine(device.ShowStatus());

        }
    }
}
