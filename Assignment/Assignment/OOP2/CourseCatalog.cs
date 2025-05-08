using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class CourseCatalog
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public List<Course> this[Level level]
        {
            get
            {
                List<Course> levelCourses = new List<Course>();
                foreach (var course in courses)
                {
                    if (course.CourseLevel == level)
                    {
                        levelCourses.Add(course);
                    }
                }
                return levelCourses;
            }
        }

        public void DisplayCoursesByLevel(Level level)
        {
            Console.WriteLine(level);
            foreach (var course in this[level])
            {
                course.DisplayInfo();
            }
        }
    }
}
