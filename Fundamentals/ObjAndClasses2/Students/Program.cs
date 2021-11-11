using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split(" ");
                string firstName = parts[0];
                string lastName = parts[1];
                string grade = parts[2];

                Student student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };
                students.Add(student);
            }
            students = students.OrderByDescending(i => i.Grade).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Grade { get; set; }

    }
}
