using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oman_Clinic_Appointment_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Clinic_Appointment_System.Configuration
{
    internal class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {

            builder.ToTable("Appointment")
               .HasKey(a => a.Id);

            builder.Property(a => a.AppointmentDate)
                .IsRequired();

            // Configure relationships
            builder.HasOne(a => a.doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
