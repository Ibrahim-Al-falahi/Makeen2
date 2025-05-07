namespace Functional4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            string[] students = new string[max];
            int[] grades = new int[max];
            int studentCount = 0;

            int choice=0;

            while (choice != 5)
            {
                Console.WriteLine("\n=== Student Grade Management ===");
                Console.WriteLine("1 → Add Student");
                Console.WriteLine("2 → Update Grade");
                Console.WriteLine("3 → View All Students and Grades");
                Console.WriteLine("4 → Show Average, Highest, and Lowest Grades");
                Console.WriteLine("5 → Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                

                switch (choice)
                {
                    case 1: 
                        if (studentCount >= max)
                        {
                            Console.WriteLine("Student limit reached.");
                            break;
                        }
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter grade (0-100): ");
                        int grade = int.Parse(Console.ReadLine());
                        if ( grade >= 0 && grade <= 100)
                        {
                            students[studentCount] = name;
                            grades[studentCount] = grade;
                            studentCount++;
                            Console.WriteLine("Student added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid grade. Must be between 0 and 100.");
                        }
                        break;

                    case 2: 
                        Console.Write("Enter student name to update: ");
                        string Name = Console.ReadLine();
                        
                        for (int i = 0; i < studentCount; i++)
                        {
                            if (students[i]== Name)
                            {
                                Console.Write("Enter new grade (0-100): ");
                                int newGrade = int.Parse(Console.ReadLine());
                                if ( newGrade >= 0 && newGrade <= 100)
                                {
                                    grades[i] = newGrade;
                                    Console.WriteLine("Grade updated.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid grade.");
                                }
                                
                                break;
                            }
                        }
                        
                        break;

                    case 3: 
                        Console.WriteLine("Student List");
                        for (int i = 0; i < studentCount; i++)
                        {
                            Console.WriteLine($"{students[i]} Grade: {grades[i]}");
                        }
                        
                        break;

                    case 4: 
                        if (studentCount == 0)
                        {
                            Console.WriteLine("No grades to analyze.");
                            break;
                        }

                        int sum = 0;
                        int highest = grades[0];
                        int lowest = grades[0];
                        

                        for (int i = 0; i < studentCount; i++)
                        {
                            sum += grades[i];
                            if (grades[i] > highest) highest = grades[i];
                            if (grades[i] < lowest) lowest = grades[i];
                        }

                        double average = sum / studentCount;
                        Console.WriteLine($"Average Grade: {average}");
                        Console.WriteLine($"Highest Grade: {highest}");
                        Console.WriteLine($"Lowest Grade: {lowest}");
                        break;

                    case 5:
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1 to 5.");
                        break;
                }

            } 
        }
    }
}
