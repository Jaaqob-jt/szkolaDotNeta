using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek2
{
    public class Lesson_7
    {
        public void TwoVariables()
        {
            int redFlag = 0;
            Console.WriteLine("Type two variables to compare:");

            while (redFlag < 5)
            {
                Console.WriteLine("Type first variable:");
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Type second variable:");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        string answer = a == b ? "equal" : "not equal";
                        Console.WriteLine($"{a} and {b} are {answer}");
                        break;
                    }
                }
                Console.WriteLine("Try again...");
                redFlag++;
            }
            Console.WriteLine("Go back - you tried enough...");
        }
        public void IsOdd()
        {
            Console.WriteLine("Type a number to check if it is odd or even");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                string answer = (a % 2) == 0 ? "even" : "odd";
                Console.WriteLine($"Number {a} is {answer}");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
            }
        }
        public void IsPositive()
        {
            Console.WriteLine("Type a number to check if it is positive or negative");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                string answer = a >= 0 ? "positive" : "negative";
                Console.WriteLine($"Number {a} is {answer}");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
            }
        }
        public void IsLeapYear()
        {
            Console.WriteLine("Type a year to check if it is a leap year");
            if (int.TryParse(Console.ReadLine(), out int a))
            {

                string answer = DateTime.IsLeapYear(a) ? "is" : "is not";
                Console.WriteLine($"Year {a} {answer} a leap year");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
            }
        }
        public void IsValidCandidate()
        {
            Console.WriteLine("Type your age to check if you can become a president");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                string answer = a switch
                {
                    _ when a < 18 => "nobody",
                    _ when a >= 18 && a < 21 => "local delegate",
                    _ when a >= 21 && a < 30 => "spokesman",
                    _ when a >= 30 && a < 35 => "senator",
                    _ when a >= 35 && a < 65 => "president",
                    _ when a >= 65 => "retired",
                    _ => throw new NotImplementedException(),
                };
                Console.WriteLine($"You are a valid candidate to be a {answer}.");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
            }
        }
        public void AssignName()
        {
            Console.WriteLine("Type your height to see who you really are");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                string answer = a switch
                {
                    _ when a < 120 => "invisible",
                    _ when a >= 120 && a < 150 => "a dwarf",
                    _ when a >= 150 && a < 170 => "supposed to be wearing heels",
                    _ when a >= 170 && a < 185 => "perfect",
                    _ when a >= 185 && a < 200 => "a chick magnet",
                    _ when a >= 200 => "the Empire State Building",
                    _ => throw new NotImplementedException(),
                };
                Console.WriteLine($"You are {answer}.");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
            }
        }
        public void MaxValue()
        {
            List<int> values = new List<int>();
            int flag = 0;
            Console.WriteLine("Type three numbers to find largest one");
            while (values.Count < 3 && flag < 5)
            {
                Console.WriteLine("Type a number:");
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    values.Add(temp);
                }
                else
                {
                    Console.WriteLine("Not a number! Try harder!");
                    flag++;
                }
            }
            if (flag > 4)
            {
                Console.WriteLine("Too many wrong values.");
            }
            else
            {
                values.Sort();
                values.Reverse();
                Console.WriteLine(values.Count > 1 ? $"Biggest value among numbers typed is {values[0]}" : "Not enough numbers typed correctly.");
            }
        }
        public void CanBeStudent()
        {
            Console.WriteLine("Type your results to check if you passed");
            int mathResult;
            int physResult;
            int chemResult;
            Console.WriteLine("What is your Maths score?");
            while (!int.TryParse(Console.ReadLine(), out mathResult))
            {
                Console.WriteLine("Try Again. What is your Maths score?");
            }
            Console.WriteLine("What is your Physics score?");
            while (!int.TryParse(Console.ReadLine(), out physResult))
            {
                Console.WriteLine("Try Again. What is your Physics score?");
            }
            Console.WriteLine("What is your Chemistry score?");
            while (!int.TryParse(Console.ReadLine(), out chemResult))
            {
                Console.WriteLine("Try Again. What is your Chemistry score?");
            }

            string answer;
            if (mathResult > 70 && physResult > 55 && chemResult > 45 && mathResult + physResult + chemResult > 180)
            {
                answer = "has";
            }
            else
            {
                answer = (mathResult + physResult > 150 || mathResult + chemResult > 150) ? "has" : "has not";
            }
            Console.WriteLine($"The candidate {answer} passed entry exam");
        }

    }
}
