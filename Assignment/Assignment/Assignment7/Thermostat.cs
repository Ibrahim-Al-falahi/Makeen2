using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Thermostat:IDevice
    {
        public bool State { get; set; }
        public int Temp { get; set; }

        public Thermostat(bool state, int temp)
        {
            State = state;
            Temp = temp;
        }

        public bool ShowStatus()
        {
            return State;
        }

        public void TurnOff()
        {
            State = false;
        }

        public void TurnOn()
        {
            State = true;
        }
    }
}
