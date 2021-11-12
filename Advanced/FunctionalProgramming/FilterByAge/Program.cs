﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Func<(string name, int age), int, bool> younger = (person, age) => person.age < age;
            Func<(string name, int age), int, bool> older = (person, age) => person.age >= age;

            List<(string name, int age)> people = new List<(string name, int age)>();

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add((person[0], int.Parse(person[1])));
            }

            string cond = Console.ReadLine();
            int filter = int.Parse(Console.ReadLine());
            string[] printFormat = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (cond == "younger")
            {
                people = people
                    .Where(p => younger(p, filter))
                    .ToList();
            }
            else if (cond == "older")
            {
                people = people
                   .Where(p => older(p, filter))
                   .ToList();
            }

            foreach (var person in people)
            {
                List<string> output = new List<string>();

                if (printFormat.Contains("name"))
                {
                    output.Add(person.name);
                }

                if (printFormat.Contains("age"))
                {
                    output.Add(person.age.ToString());
                }

                Console.WriteLine(string.Join(" - ", output));
            }
        }
    }
}
