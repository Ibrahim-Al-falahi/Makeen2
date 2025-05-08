using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Light:ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Light is ON");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Light is OFF.");
        }

        public void ShowStatus()
        {
            Console.WriteLine(isOn ? "ON" : "OFF");
        }
    }
}
