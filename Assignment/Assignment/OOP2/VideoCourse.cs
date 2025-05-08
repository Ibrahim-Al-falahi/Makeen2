using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP2
{
    internal class VideoCourse:Course
    {
        public double Duration { get; set; }

        public VideoCourse(string name, string instructor, Level level, double duration)
            : base(name, instructor, level)
        {
            Duration = duration;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} : {Instructor} : {CourseLevel} : {Duration}");
        }
    }
}
