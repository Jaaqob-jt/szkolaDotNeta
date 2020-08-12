using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HomeworkWeek2
{
    public class Lesson_7 // Klasa mogłaby być statyczna w tym przypadku
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
            Console.WriteLine(redFlag < 5 ? "" : "Go back - you tried enough...");
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
        public void DescribeGrade()
        {
            Console.WriteLine("Type your grade to see how it should be written");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                string answer = a switch
                {
                    1 => "Niedostateczny",
                    2 => "Dopuszczający",
                    3 => "Dostateczny",
                    4 => "Dobry",
                    5 => "Bardzo Dobry",
                    6 => "Celujący",
                    _ => "Something else"
                };
                Console.WriteLine($"You got \"{answer}\".");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
            };
        }
        public void Calculation() // Mogłem zrobić oddzielna klasę, ale stwierdziłem, że zaburzę tym sobie hierarchię
        {
            int redFlag = 0;
            Console.WriteLine("Type two variables for simple calculation:");

            while (redFlag < 5)
            {
                Console.WriteLine("Type first variable:");
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Type second variable:");
                    if (int.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
                        if (int.TryParse(Console.ReadLine(), out int operation))
                        {
                            string result = operation switch
                            {
                                1 => (a + b).ToString(),
                                2 => (a - b).ToString(),
                                3 => (a * b).ToString(),
                                4 => b==0 ? "NaN" : (a/b).ToString(),
                                _ => "Bad declaration",
                            };
                            Console.WriteLine($"You got \"{result}\".");
                            break;
                        }
                    }
                }
                Console.WriteLine("Try again...");
                redFlag++;
            }
            Console.WriteLine(redFlag < 5 ? "" : "Go back - you tried enough...");
        }
        public void DescribeDayOfTheWeek()
        {
            Console.WriteLine("Type your day of the week to see how it should be written");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                string answer = a switch
                {
                    1 => "Poniedziałek",
                    2 => "Wtorek",
                    3 => "Środa",
                    4 => "Czwartek",
                    5 => "Piątek",
                    6 => "Sobota",
                    7 => "Niedziela",
                    _ => "Not a week day"
                };
                Console.WriteLine($"It is \"{answer}\".");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
            };
        }
        public void CanBeTriangle()
        {
            int[] lengths = new int[3];
            int flag = 0;
            Console.WriteLine("Type three numbers to find out, if they can be put together to form a trianglr.");
            for (int i = 0; i < lengths.Count(); i++)
            {
                Console.WriteLine("Type length:");
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    lengths[i] = temp;
                }
                else
                {
                    Console.WriteLine("Not a number! Try harder!");
                    flag++;
                    if (flag > 5)
                    {
                        Console.WriteLine("Too many wrong values.");
                        break;
                    }
                }
            }
            if (lengths[0] + lengths[1] > lengths[2] && lengths[0] + lengths[2] > lengths[1] && lengths[2] + lengths[1] > lengths[0])
            {
                Console.WriteLine($"You can build a triangle.");
            }
            else
            {
                Console.WriteLine($"You can not build a triangle.");
            }
        }
        public void DescribeTemperature()
        {
            Console.WriteLine("Type current temperature to get a description");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                string answer = a switch
                {
                    _ when a < 0 => "Bloody Freezing!",
                    _ when a >= 0 && a < 10 => "Cold.",
                    _ when a >= 10 && a < 20 => "Chilly.",
                    _ when a >= 20 && a < 30 => "Just right.",
                    _ when a >= 30 && a < 40 => "To hot.",
                    _ when a >= 40 => "Time to move to Alaska!",
                    _ => throw new NotImplementedException(),
                };
                Console.WriteLine($"It is {answer}");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
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
