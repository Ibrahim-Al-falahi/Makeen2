using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class SmartHome
    {
        private Dictionary<DeviceType, ISmartDevice> devices = new Dictionary<DeviceType, ISmartDevice>();

        public SmartHome()
        {
            devices[DeviceType.Light] = new Light();
            devices[DeviceType.Fan] = new Fan();
            devices[DeviceType.AC] = new AC();
            devices[DeviceType.Heater] = new Heater();
        }

        // Indexer to access devices by DeviceType
        public ISmartDevice this[DeviceType type]
        {
            get
            {
                if (devices.ContainsKey(type))
                    return devices[type];
                else return null;
            }
            
        }

        // Method to display the status of all devices
        public void ShowAllStatuses()
        {
            Console.WriteLine("Device Statuses");
            foreach (var device in devices)
            {
                Console.Write($"{device.Key}: ");
                device.Value.ShowStatus();
            }
        }
    }
}
