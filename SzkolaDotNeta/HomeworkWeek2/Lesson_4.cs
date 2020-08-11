using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek2
{
    // Zadanie 1 Lekcja 4
    class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; private set; }
        public string Pesel { get; private set; }
        public int Id { get; private set; }

        public Worker(string firstName, string lastName, int age, Gender gender, string pesel)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Pesel = pesel;
            Id = int.Parse($"{DateTime.Now.DayOfYear}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Millisecond}");
        }
        public static Worker WorkerCreationSteps(string alias)
        {
            Console.WriteLine($"What is {alias}s First name?");
            string firstName = Console.ReadLine();
            Console.WriteLine($"What is {alias}ss Last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"What is {alias}ss Age?");
            int age;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                age = 20;
            }
            Console.WriteLine($"What is {alias}s PESEL?");
            string pesel = Console.ReadLine();
            Console.WriteLine($"What is {alias}s Gender? [0] Male [1] Female");
            Gender gender;
            if (!Enum.TryParse(Console.ReadLine(), out gender))
            {
                gender = Gender.Male;
            }

            return new Worker(firstName, lastName, age, gender, pesel);
        }

        public override string ToString()
        {
            string result;
            result = $"First Name = {FirstName}\nLast Name = {LastName}\nAge = {Age}\nGender = {Gender}\nPESEL = {Pesel}\nId = {Id}";
            return result;
        }
    }

    class Lesson_4
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
                        break;
                    }
                }
                Console.WriteLine("Try again...");
                    redFlag++;
                }
            string log = redFlag < 5 ? $"Diagonal length of rectangle with a = {a} and b = {b} is {result}" : "Go back - you tried enough...";
            Console.WriteLine(log);
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
