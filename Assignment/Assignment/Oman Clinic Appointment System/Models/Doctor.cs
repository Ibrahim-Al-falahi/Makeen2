using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Clinic_Appointment_System.Models
{
    internal class Doctor:Person
    {
        public string Speciality { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
