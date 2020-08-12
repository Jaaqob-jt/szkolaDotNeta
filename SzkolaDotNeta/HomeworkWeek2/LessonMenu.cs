using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkWeek2
{
    public static class LessonMenu
    {
        /// <summary>
        /// Przerobiłem kod z poprzedniej lekcji tak, żeby można było zrobić z tego w miarę czytelne menu uzytkownika.
        /// </summary>
        public static void Lesson4()
        {
            // Initialization of some fields to operate on.
            string option = "0";
            List<Worker> workers = new List<Worker>();
            List<Worker> users = new List<Worker>();

            while (option.ToLower() != "e")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nWelcome to Lesson 4 form Week 2. Please choose a topic to review:");
                // Options to choose from:
                Console.WriteLine("\n1. Create your brand new worker!");
                Console.WriteLine("2. Reverse your input!");
                Console.WriteLine("3. Calculate diagonal length of a rectangle!");
                Console.WriteLine("4. Get three types of data!");
                Console.WriteLine("5. Parse some data!");
                Console.WriteLine("Press any other key to exit to Lesson Menu.");
                Console.WriteLine();
                option = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                // Actions based on chosen option:
                switch (option)
                {
                    case "1":
                        workers.Add(Worker.WorkerCreationSteps("new worker"));
                        Console.WriteLine(workers.ElementAt(workers.Count() - 1).ToString());
                        break;
                    case "2":
                        Lesson_4.Reverse();
                        break;
                    case "3":
                        Lesson_4.DiagonalLength();
                        break;
                    case "4":
                        Lesson_4.Assignments();
                        break;
                    case "5":
                        Console.WriteLine("Kind of the same operation, as in first assignment...\n[Reusable code detected]");
                        users.Add(Worker.WorkerCreationSteps("new user"));
                        Console.WriteLine(users.ElementAt(users.Count() - 1).ToString());
                        break;
                    default:
                        option = "e";
                        break;
                }
            }
        }

        /// <summary>
        /// Pozwoliłem sobie na przetłumaczenie większosci zadań na angielski - było mi tak łatwiej.
        /// Mam też dużo kodu, który można wyciagnąć i zrobić z tego metody bardziej ogólne i wprowadzić odwołania do metod z wewnątrz metod, zastosować parametry.
        /// Ogólnie mogłoby być czyściej.
        /// </summary>
        public static void Lesson7() 
        {
            // Initialization of some fields to operate on.
            string option = "0";
            Lesson_7 lesson = new Lesson_7();

            while (option.ToLower() != "e")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nWelcome to Lesson 7 form Week 2. Please choose a topic to review:");
                // Options to choose from:
                Console.WriteLine("\n1. Compare two variables");
                Console.WriteLine("2. Check if typed number is odd or even");
                Console.WriteLine("3. Check if typed number is positive or negative");
                Console.WriteLine("4. Check if typed year is a leap year");
                Console.WriteLine("5. Check if you can become a president");
                Console.WriteLine("6. Check how your heigth determines your fate");
                Console.WriteLine("7. Find biggest number");
                Console.WriteLine("8. Check if you can become a student");
                Console.WriteLine("9. Describe temperature");
                Console.WriteLine("A. Check if you can build a triangle out of three given lengths");
                Console.WriteLine("B. Check description of your grade");
                Console.WriteLine("C. Check day of the week");
                Console.WriteLine("D. Calculate something");
                Console.WriteLine("Press any other key to exit to Lesson Menu.");
                Console.WriteLine();
                option = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                // Actions based on chosen option:
                switch (option.ToLower())
                {
                    case "1":
                        lesson.TwoVariables();
                        break;
                    case "2":
                        lesson.IsOdd();
                        break;
                    case "3":
                        lesson.IsPositive();
                        break;
                    case "4":
                        lesson.IsLeapYear();
                        break;
                    case "5":
                        lesson.IsValidCandidate();
                        break;
                    case "6":
                        lesson.AssignName();
                        break;
                    case "7":
                        lesson.MaxValue();
                        break;
                    case "8":
                        lesson.CanBeStudent();
                        break;
                    case "9":
                        lesson.DescribeTemperature();
                        break;
                    case "a":
                        lesson.CanBeTriangle();
                        break;
                    case "b":
                        lesson.DescribeGrade();
                        break;
                    case "c":
                        lesson.DescribeDayOfTheWeek();
                        break;
                    case "d":
                        lesson.Calculation();
                        break;
                    default:
                        option = "e";
                        break;
                }
            }
            
        }
    }
}
