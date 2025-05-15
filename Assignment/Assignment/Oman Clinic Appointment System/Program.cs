using System.IO;
using System.Net;
using Oman_Clinic_Appointment_System.Context;
using Oman_Clinic_Appointment_System.Models;

namespace Oman_Clinic_Appointment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext db = new ApplicationDbContext();

            int choice = 0;

            while (choice != 7)
            {

                Console.WriteLine("1. Register New Patient");
                Console.WriteLine("2. Add New Doctor");
                Console.WriteLine("3. Search Doctor by Specialty");
                Console.WriteLine("4. Book Appointment");
                Console.WriteLine("5. View Patient Appointments");
                Console.WriteLine("6. View All Appointments");
                Console.WriteLine("7. Exit");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Patient Name");
                        string addPName = Console.ReadLine();
                        Console.WriteLine("Enter Patient phone number");
                        string addPphone = Console.ReadLine();
                        Console.WriteLine("Enter Patient national Id");
                        int addPId = int.Parse(Console.ReadLine());

                        Register(addPName,addPphone,addPId,db);

                        break;
                    case 2:
                        Console.WriteLine("Enter Doctor Name");
                        string addDName = Console.ReadLine();
                        Console.WriteLine("Enter Doctor phone number");
                        string adddphone = Console.ReadLine();
                        Console.WriteLine("Enter Doctor speciality");
                        string adddSpeciality = Console.ReadLine();

                        AddDoctor(addDName, adddphone, adddSpeciality, db);
                        break;
                    case 3:
                        Console.WriteLine("Enter Doctor speciality");
                        string searchSpeciality = Console.ReadLine();
                        Search(searchSpeciality,db);
                        break;
                    case 4:
                        Console.WriteLine("Enter Patient national Id");
                        int bookPId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Doctor Name");
                        string bookDName = Console.ReadLine();
                        Console.Write("Enter a date (e.g., yyyy-mm-dd): ");
                        string input = Console.ReadLine();

                        if (DateTime.TryParse(input, out DateTime date))
                        {
                            Book(bookDName,bookPId,date,db);
                        }
                        else
                        {
                            Console.WriteLine("Invalid date format. Please enter a valid date.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter Patient national Id");
                        int viewPId = int.Parse(Console.ReadLine());
                        ViewPatientAppointments(viewPId,db);
                        break;
                    case 6:
                        ViewAllAppointments(db);
                        break;

                    case 7:
                        Console.WriteLine("Bye");
                        break;

                }


            }
        }

        public static void Register(string name,string phoneNumber,int nationalId, ApplicationDbContext db)
        {
            Patient patient = new Patient()
            {
                Name = name,
                PhoneNumber = phoneNumber,
                NationalId = nationalId
            };
            
            db.Add(patient);
            db.SaveChanges();
            Console.WriteLine("Patient registered successfully!");
        }
        public static void AddDoctor(string name, string phoneNumber, string speciality, ApplicationDbContext db)
        {
            Doctor doctor = new Doctor()
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Speciality = speciality
            };

            db.Add(doctor);
            db.SaveChanges();
            Console.WriteLine("Doctor added successfully!");
        }

        public static void Search(string speciality, ApplicationDbContext db)
        {
            var doc = (from d in db.Doctor
                       where d.Speciality == speciality
                       select d).FirstOrDefault();
            if (doc != null)
            {
                Console.WriteLine(doc.Name + " | Phone: " + doc.PhoneNumber);
            }
            else
            {
                Console.WriteLine("No Such a Doctor here");
            }
                
        }

        public static void Book(string name,int nationalId, DateTime date, ApplicationDbContext db)
        {
            var doc = (from d in db.Doctor
                       where d.Name == name
                       select d).FirstOrDefault();

            var pat = (from p in db.Patient
                       where p.NationalId == nationalId
                       select p).FirstOrDefault();

            if (doc != null && pat != null)
            {

                Appointment appointment = new Appointment()
                {
                    AppointmentDate = date,
                    PatientId = pat.Id,
                    DoctorId = doc.Id
                };

                db.Add(appointment);
                db.SaveChanges();
                Console.WriteLine("Appointment booked successfully!");
            }
            else
            {
                Console.WriteLine("Doctor name or National Id is wrong ");
            }

        }
        public static void ViewPatientAppointments(int nationalId, ApplicationDbContext db)
        {
            var patientAppointments = from p in db.Patient
                                       where p.NationalId == nationalId
                                       from a in p.Appointments
                                       select new
                                       {
                                           PName = p.Name,
                                           ADate = a.AppointmentDate

                                       };

            foreach (var item in patientAppointments)
            {
                Console.WriteLine("Patient: " + item.PName + " | Date: " + item.ADate);
            }
            
        }

        public static void ViewAllAppointments( ApplicationDbContext db)
        {
            var Appointments = from a in db.Appointment
                               join p in db.Patient on a.PatientId equals p.Id
                               join d in db.Doctor on a.DoctorId equals d.Id
                                      select new
                                      {
                                          DName=d.Name,
                                          DSpeciality=d.Speciality,
                                          PName = p.Name,
                                          ADate = a.AppointmentDate

                                      };

            foreach (var item in Appointments)
            {
                Console.WriteLine($"Patient: {item.PName} | Doctor: {item.DName} | Speciality: {item.DSpeciality} | Date: {item.ADate} |");
            }

        }
    }
}
