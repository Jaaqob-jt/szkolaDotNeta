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
            Console.WriteLine("Hello There!\nWhich Lesson would you like to participate in?");
            while (option.ToLower() != "e")
            {
                // Options to choose from:
                Console.WriteLine("\n1. Lesson 4");
                Console.WriteLine("Press any other key to exit program.");
                Console.WriteLine();
                option = Console.ReadLine();

                // Actions based on chosen option:
                switch (option)
                {
                    case "1":
                        LessonMenu.Lesson4();
                        break;
                    default:
                        option = "e";
                        break;
                }
            }
        }
    }
}
