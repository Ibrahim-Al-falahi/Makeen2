using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class TicketSystem
    {
        private List<Ticket> tickets = new List<Ticket>();

        public Ticket this[string seatNumber]
        {
            get
            {
                foreach (var item in tickets)
                {
                    if (item.SeatNumber == seatNumber)
                        return item;
                    
                }
                return null;
            }
            set
            {
                tickets.Add(value);
            }
            
        }

        //public int this[int index, string s]
        //{
        //    get
        //    {
        //        for (int i = 0; i < size; i++)
        //        {
        //            if (this.name[i] == s)
        //            {
        //                return number[i];
        //            }
        //        }
        //        return -1;
        //    }
        //    set
        //    {
        //        this.name[index] = s;
        //        number[index] = value;


        //    }
        //}

        

        public void CountTicketsByType()
        {
            int regularCount = 0, vipCount = 0, backstageCount = 0;

            foreach (var ticket in tickets)
            {
                switch (ticket.Type)
                {
                    case TicketType.Regular:
                        regularCount++;
                        break;
                    case TicketType.VIP:
                        vipCount++;
                        break;
                    case TicketType.Backstage:
                        backstageCount++;
                        break;
                }
            }

            Console.WriteLine($"Regular: {regularCount}");
            Console.WriteLine($"VIP: {vipCount}");
            Console.WriteLine($"Backstage: {backstageCount}");
        }
    }
}
