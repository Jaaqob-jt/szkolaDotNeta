using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkWeek2
{
    class Lesson_8
    {
        internal static void ListPrimes()
        {
            int i = 3;
            bool isPrime;
            int primesRange = 100;
            List<int> primes = new List<int>();
            primes.Add(2);

            Console.WriteLine("Type a number to all primes below it");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                primesRange = a;
            }
            Console.WriteLine($"Checking for primes below {primesRange}");

            while (i <= primesRange)
            {
                isPrime = true;
                foreach (int divider in primes)
                {
                    if (i % divider == 0) 
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
                i++;
            }
            Console.WriteLine($"Total number of Primes below {primesRange} is {primes.Count}\nPrimes listed:");
            foreach (int item in primes)
            {
                Console.Write($" {item},");
            }
        }
        internal static void ListEvens()
        {
            Console.WriteLine("All even numbers below 1000 listed:");
            int i = 1;
            do
            {
                if (i % 2 == 0) Console.Write($"{i}, ");
                i++;
            } while (i < 1001 );

        }
        internal static void Fibonacci()
        {
            double fibbRange = 100;
            Console.WriteLine("Type desired length of Fibonacchi");
            if (double.TryParse(Console.ReadLine(), out double a))
            {
                fibbRange = a;
            }
            Console.Write($"Checking for {fibbRange} numbers of Fibonacci:\n1, 1, ");
            Queue<double> fibonacci = new Queue<double>();
            fibonacci.Enqueue(1);
            fibonacci.Enqueue(1);

            for (int i = 0; i < fibbRange; i++)
            {
                double fib1 = fibonacci.Peek();
                double fib2 = fibonacci.Dequeue() + fibonacci.Dequeue();
                fibonacci.Enqueue(fib2);
                fibonacci.Enqueue(fib1);
                Console.Write($"{fibonacci.Peek()}, ");
            }

        }
        internal static void DisplayPiramide()
        {
            int range = 100;
            int indexer = 1;
            int length = 1;
            Console.WriteLine("Type a number");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                range = a;
            }
            Console.WriteLine($"Displayng for {range} numbers:");
            while (indexer < range)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"{indexer++} "); 
                }
                Console.WriteLine("");
                length++;
            }

        }
        internal static void ThirdPower()
        {
            double number = 0;
            for (int i = 1; i < 21; i++)
            {
                number = Math.Pow(i, 3);
                Console.WriteLine($"{i} to power 3 is equal to {number}");
            }
        }
        internal static void SumOfFractions()
        {
            double number = 0;
            for (double i = 1; i < 21; i++)
            {
                number += 1 / i;
                Console.WriteLine($".\t1/{i}\t. Partial sum of numbers is equal to {number}");
            }
            Console.WriteLine($"Total is equal to {number}");
        }
        internal static void ReverseString()
        {
            Console.WriteLine("Type something to get reversed version");
            string text = Console.ReadLine();
            char[] result = text.ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);
        }
        internal static void DecimalToBinary()
        { 
        Console.WriteLine("Type a number to convert to binary");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine($"Number {a} is binary {Convert.ToString(a, 2)}");
            }
            else
            {
                Console.WriteLine("Not a valid value. Back to menu.");
            }
        }
    }
}
