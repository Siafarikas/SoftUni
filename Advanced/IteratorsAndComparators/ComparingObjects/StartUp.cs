using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(info[0], int.Parse(info[1]), info[2]));
            }
            int idxComparator = int.Parse(Console.ReadLine()) - 1;

            int matches = 0;
            foreach (Person person in people)
            {
                if (people[idxComparator].CompareTo(person) == 0)
                {
                    matches++;
                }
            }
            if (matches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
        }
    }
}
