using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Model
{
    internal class Airline
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Name cannot be null or empty
        [Length(50,100)] // Min and Max length of char in a string
        public string Name { get; set; }

        [Phone] // Phone number format
        [Range(8,11)] // Numeric range
        public int ContactNumber { get; set; }

        [EmailAddress] // Email address format ( 123@123.com )
        public string Email { get; set; }

        [MinLength(3)] // the string must be at least 3 chars
        public string Representer { get; set; }
    }
}
