using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek2
{
    // Zadanie 1
    class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; private set; }
        public int Pesel { get; private set; }      // mógłby być też string
        public int Id { get; private set; }

        public Worker(string firstName, string lastName, int age, Gender gender, int pesel)
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
            int pesel;
            if (!int.TryParse(Console.ReadLine(), out pesel))
            {
                pesel = 123456789;
            }
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
            result = $"First Name = {FirstName}\nLast Name = {LastName}\nAge = {Age}\nGender = {Gender}\n PESEL = {Pesel}\nId = {Id}";
            return result;
        }
    }
    public enum Gender
    {
        Male,
        Female
    }
}
