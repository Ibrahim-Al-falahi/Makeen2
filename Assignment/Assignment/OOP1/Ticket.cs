using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Ticket
    {
        public string EventName { get; set; }
        public string SeatNumber { get; set; }
        public TicketType Type { get; set; }

        public Ticket(string eventName, string seatNumber, TicketType type)
        {
            EventName = eventName;
            SeatNumber = seatNumber;
            Type = type;
        }

        public override string ToString()
        {
            return $"Event: {EventName}, Seat: {SeatNumber}, Type: {Type}";
        }
    }
}
