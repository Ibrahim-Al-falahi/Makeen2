namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student(1, "Ace");
            Student s2 = new Student(2, "Heart");
            Student s3 = new Student(3, "Spade");

            s1.AddGrade(65);
            s1.AddGrade(86);
            s1.AddGrade(14);

            s2.AddGrade(22);
            s2.AddGrade(33);
            s2.AddGrade(66);

            s3.AddGrade(91);
            s3.AddGrade(68);
            s3.AddGrade(23);

            s1.CalculateAverage();
            s2.CalculateAverage();
            s3.CalculateAverage();

            Console.WriteLine(s1.PrintStudentReport());
            Console.WriteLine(s2.PrintStudentReport());
            Console.WriteLine(s3.PrintStudentReport());

        }
    }
}
