using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    internal class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public char Gender { get; set; }
        public string Nationality { get; set; }
        public int PassportNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }



    }
}
