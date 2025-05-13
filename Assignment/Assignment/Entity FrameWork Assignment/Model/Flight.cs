using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    internal class Flight
    {
        [Key] // Primary key
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")] // validate char A-Z and max Length 40 char
        public string Departure { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Characters are not allowed.")] // validate char A-Z and max Length 40 char , show error message if violates the rules
        public string Destination { get; set; }

        [DataType(DataType.Time)] // save data type in database as Time
        public string DepartureTime { get; set; }

        [DataType(DataType.Time)] // save data type in database as Time
        public string ArrivalTime { get; set; }

        [ForeignKey(nameof(Gate))] // Foreign Key 
        public int Gate { get; set; }

    }
}
