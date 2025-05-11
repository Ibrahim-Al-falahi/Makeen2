using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    internal class Checkpoint
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public string TerminalName { get; set; }
        public int PassengerCapacity { get; set; }
        public string Location { get; set; }
    }
}
