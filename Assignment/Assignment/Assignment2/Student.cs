using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<int> Grade;


        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Grade = new List<int>();
        }

        public void AddGrade(int grade)
        {
            Grade.Add(grade);
        }
        public double CalculateAverage()
        {
            double sum = 0;
            foreach (var grade in Grade)
            {
                sum += grade;
            }
            return sum/Grade.Count;
        }

        public string PrintStudentReport()
        {
            string result=$"{Id} : {Name}";

            foreach (var grade in Grade)
            {
                result += " "+grade;
            }
            return result;
        }
    }
}
