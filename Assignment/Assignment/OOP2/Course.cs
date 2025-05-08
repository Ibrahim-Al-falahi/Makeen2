using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    abstract class Course
    {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public Level CourseLevel { get; set; }

        protected Course(string name, string instructor, Level level)
        {
            Name = name;
            Instructor = instructor;
            CourseLevel = level;
        }

        public abstract void DisplayInfo();
    }
}
