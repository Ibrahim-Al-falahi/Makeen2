using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class AC:ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("AC is ON");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("AC is OFF.");
        }

        public void ShowStatus()
        {
            Console.WriteLine(isOn ? "ON" : "OFF");
        }
    }
}
