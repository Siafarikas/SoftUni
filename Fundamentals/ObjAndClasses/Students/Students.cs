using System;
using System.Collections.Generic;

namespace Students
{
    class Students
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] parts = input.Split();
                Student student = new Student
                {
                    FirstName = parts[0],
                    LastName = parts[1],
                    Age = parts[2],
                    Hometown = parts[3]
                };

                students.Add(student);
                input = Console.ReadLine();
            }
            string filterHometown = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Hometown == filterHometown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Hometown { get; set; }

    }
}
