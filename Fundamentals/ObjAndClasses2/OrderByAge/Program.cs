using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] parts = input.Split();
                string name = parts[0];
                string id = parts[1];
                int age = int.Parse(parts[2]);
                Person person = new Person
                {
                    Name = name,
                    Id = id,
                    Age = age
                };
                people.Add(person);
            }

            List<Person> sortedList = people
                .OrderBy(i => i.Age)
                .ToList();

            foreach (Person person in sortedList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
}
