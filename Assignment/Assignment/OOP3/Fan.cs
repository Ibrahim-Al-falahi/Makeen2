using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Fan:ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Fan is ON");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Fan is OFF.");
        }

        public void ShowStatus()
        {
            Console.WriteLine(isOn ? "ON" : "OFF");
        }
    }
}
