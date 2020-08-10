using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek2
{
    class Utility
    {
        // Zadanie 2
        public static void Reverse()
        {
            Console.WriteLine("Type value for \'a\'");
            string a = Console.ReadLine();
            Console.WriteLine("Type value for \'b\'");
            string b = Console.ReadLine();
            Console.WriteLine("Type value for \'c\'");
            string c = Console.ReadLine();
            Console.WriteLine($"c = {c}\nb = {b}\na = {a}");
        }
        // Zadanie 3
        public static void DiagonalLength()
        {
            int redFlag = 0;
            double a = 0;
            double b = 0;
            double result = 0;

            while (redFlag < 5)
            {
                Console.WriteLine("Type first length:");
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Type second length:");
                    if (double.TryParse(Console.ReadLine(), out b))
                    {
                        result =  Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                        Console.WriteLine($"Diagonal length of rectangle with a = {a} and b = {b} is {result}");
                        break;
                    }
                }
                Console.WriteLine("Try again...");
                    redFlag++;
                }
        }

        // Zadanie 4
        public static void Assignments()
        {
            int integer = 10;
            string text = "Szkoła Dotneta";
            double precisionNumber = 12.5;
            Console.WriteLine($"Assigned:\nInteger\t{integer}\nString\t{text}\nDouble\t{precisionNumber}");
        }
    }
}
