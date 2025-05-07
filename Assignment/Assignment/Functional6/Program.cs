namespace Functional6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            string[] tasks = new string[max];
            bool[] isCompleted = new bool[max];
            int taskCount = 0;
            int choice=0;

            while (choice != 6)
            {
                Console.WriteLine("To Do List Menu");
                Console.WriteLine("1 Add Task");
                Console.WriteLine("2 Delete Task");
                Console.WriteLine("3 Mark Task as Completed");
                Console.WriteLine("4 View Tasks");
                Console.WriteLine("5 Clear Completed Tasks");
                Console.WriteLine("6 Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        if (taskCount >= max)
                        {
                            Console.WriteLine("Task list is full");
                            break;
                        }

                        Console.Write("Enter task description: ");
                        tasks[taskCount] = Console.ReadLine();
                        isCompleted[taskCount] = false;
                        taskCount++;
                        Console.WriteLine("Task added");
                        break;

                    case 2: 
                        Console.Write("Enter task number to delete: ");
                        int delete = int.Parse(Console.ReadLine());
                        if (delete >= 1 && delete <= taskCount)
                        {
                            for (int i = delete - 1; i < taskCount - 1; i++)
                            {
                                tasks[i] = tasks[i + 1];
                                isCompleted[i] = isCompleted[i + 1];
                            }
                            taskCount--;
                            Console.WriteLine("Task deleted");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number");
                        }
                        break;

                    case 3: 
                        Console.Write("Enter task number: ");
                        int completeIndex = int.Parse(Console.ReadLine());
                        if ( completeIndex >= 1 && completeIndex <= taskCount)
                        {
                            isCompleted[completeIndex - 1] = true;
                            Console.WriteLine("completed");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number");
                        }
                        break;

                    case 4: 
                        Console.WriteLine("Task List");
                        if (taskCount == 0)
                        {
                            Console.WriteLine("No tasks");
                        }
                        else
                        {
                            for (int i = 0; i < taskCount; i++)
                            {
                                string status = isCompleted[i] ? "Done" : "Pending";
                                Console.WriteLine($"{tasks[i]} : {status}");
                            }
                        }
                        break;

                    case 5: 
                        int originalCount = taskCount;
                        int j = 0;
                        for (int i = 0; i < originalCount; i++)
                        {
                            if (!isCompleted[i])
                            {
                                tasks[j] = tasks[i];
                                isCompleted[j] = false;
                                j++;
                            }
                        }
                        taskCount = j;
                        Console.WriteLine("Cleared");
                        break;

                    case 6:
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }
        }
    }
}
