using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Light:IDevice
    {

        public bool State { get; set; }
        public int Brightness { get; set; }

        public Light(bool state, int brightness)
        {
            State = state;
            Brightness = brightness;
        }

        public bool ShowStatus()
        {
            return State;
        }

        public void TurnOff()
        {
            State=false;
        }

        public void TurnOn()
        {
            State = true;
        }
    }
}
