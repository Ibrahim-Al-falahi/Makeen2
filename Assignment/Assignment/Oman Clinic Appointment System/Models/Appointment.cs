using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Clinic_Appointment_System.Models
{
    internal class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Patient patient { get; set; }
        public int PatientId { get; set; }

        public Doctor doctor { get; set; }
        public int DoctorId { get; set; }

    }
}
