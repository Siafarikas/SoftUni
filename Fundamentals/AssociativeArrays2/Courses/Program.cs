using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
           
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] parts = input.Split(" : ");
                string courseName = parts[0];
                string studentName = parts[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string> { studentName });
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }

            courses = courses.OrderByDescending(i => i.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var course in courses)
            {
                course.Value.Sort();
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
