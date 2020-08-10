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
            Console.WriteLine($"Hello Stranger! What Would you like to see? \nMake your choice!\n");
            string option = "0";
            List<Worker> workers = new List<Worker>();
            List<Worker> users = new List<Worker>();

            while (option.ToLower() != "e")
            {
                // Options to choose from:
                Console.WriteLine("\n1. Create your brand new worker!");
                Console.WriteLine("2. Reverse your input!");
                Console.WriteLine("3. Calculate diagonal length of a rectangle!");
                Console.WriteLine("4. Get three types of data!");
                Console.WriteLine("5. Parse some data!");
                Console.WriteLine("Press any other key to exit.");
                Console.WriteLine();
                option = Console.ReadLine();

                // Actions based on chosen option:
                switch (option)
                {
                    case "1":
                        workers.Add(Worker.WorkerCreationSteps("new worker"));
                        Console.WriteLine(workers.ElementAt(workers.Count()-1).ToString());
                        break;
                    case "2":                       
                        Utility.Reverse();
                        break;
                    case "3":
                        Utility.DiagonalLength();
                        break;
                    case "4":
                        Utility.Assignments();
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
    }
}
