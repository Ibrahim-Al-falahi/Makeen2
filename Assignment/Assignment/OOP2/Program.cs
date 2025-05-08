namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseCatalog catalog = new CourseCatalog();

            catalog.AddCourse(new VideoCourse("C#", "A", Level.Beginner, 5.0));
            catalog.AddCourse(new VideoCourse("React", "B", Level.Intermediate, 7.5));
            catalog.AddCourse(new VideoCourse("Python", "C", Level.Advanced, 10.0));

            catalog.AddCourse(new LiveSession("HTML", "D", Level.Beginner, DateTime.Now.AddDays(2)));
            catalog.AddCourse(new LiveSession("ASP", "E", Level.Advanced, DateTime.Now.AddDays(5)));

            catalog.DisplayCoursesByLevel(Level.Beginner);
            catalog.DisplayCoursesByLevel(Level.Intermediate);
            catalog.DisplayCoursesByLevel(Level.Advanced);
        }
    }
}
