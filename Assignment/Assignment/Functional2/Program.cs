namespace Functional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = {
            "What is the capital of France?",
            "Which planet is known as the Red Planet?",
            "What is the largest ocean on Earth?",
            "Which language is used to create Android apps?",
            "What is the square root of 64?"
            };

            string[,] options = {
            { "A) Berlin", "B) Madrid", "C) Paris", "D) Rome" },
            { "A) Earth", "B) Mars", "C) Venus", "D) Jupiter" },
            { "A) Indian", "B) Atlantic", "C) Arctic", "D) Pacific" },
            { "A) Python", "B) Java", "C) Swift", "D) C++" },
            { "A) 6", "B) 7", "C) 8", "D) 9" }
            };

            char[] answers = { 'C', 'B', 'D', 'B', 'C' };

            int score = 0;

            Console.WriteLine("Welcome to the Quiz");

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(options[i, j]);
                }

                Console.Write("Your answer (A/B/C/D): ");
                string input = Console.ReadLine().ToUpper();


                if (input[0] == answers[i])
                {
                    Console.WriteLine("Correct ");
                    score++;
                }
                else
                {
                    Console.WriteLine($" Wrong, Correct answer is: {answers[i]}");
                }

            }

            Console.WriteLine($"Total score: {score}/5");

            switch (score)
            {
                case 5:
                    Console.WriteLine("Excellent");
                    break;
                case 4:
                    Console.WriteLine("Excellent");
                    break;
                case 3:
                    Console.WriteLine("Good");
                    break;
                case 2:
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;
            }
        }
    }
}
