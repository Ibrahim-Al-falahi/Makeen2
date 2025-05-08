using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP2
{
    internal class LiveSession:Course
    {
        public DateTime Schedule { get; set; }

        public LiveSession(string name, string instructor, Level level, DateTime schedule)
            : base(name, instructor, level)
        {
            Schedule = schedule;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} : {Instructor} : {CourseLevel} : {Schedule}");
        }
    }
}
