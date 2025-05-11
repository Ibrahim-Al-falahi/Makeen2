using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    internal class Gate
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public int Number { get; set; }
        public int AirlineId { get; set; }
        public bool Availability { get; set; }

    }
}
