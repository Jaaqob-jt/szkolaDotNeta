using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "0";
            while (option.ToLower() != "e")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                // Options to choose from:
                Console.WriteLine("\nHello There!\nWhich Lesson would you like to participate in?");
                Console.WriteLine("\n1. Lesson 4");
                Console.WriteLine("2. Lesson 7");
                Console.WriteLine("3. Lesson 8");
                Console.WriteLine("Press any other key to exit program.");
                Console.WriteLine();
                option = Console.ReadLine();

                // Actions based on chosen option:
                switch (option)
                {
                    case "1":
                        LessonMenu.Lesson4();
                        break;
                    case "2":
                        LessonMenu.Lesson7();
                        break;
                    case "3":
                        LessonMenu.Lesson8();
                        break;
                    default:
                        option = "e";
                        break;
                }
            }
        }
    }
}
