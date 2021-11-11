using System;
using System.Collections.Generic;

namespace Students2
{
    class Students2
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] parts = input.Split();
                if (Exists(students, parts[0], parts[1]))
                {
                    Student student = GetStudent(students, parts[0], parts[1]);

                    student.FirstName = parts[0];
                    student.LastName = parts[1];
                    student.Age = parts[2];
                    student.Hometown = parts[3];
                }
                else
                {
                    Student student = new Student
                    {
                        FirstName = parts[0],
                        LastName = parts[1],
                        Age = parts[2],
                        Hometown = parts[3]
                    };
                    students.Add(student);
                }
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

        static bool Exists(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string Hometown { get; set; }

        }
    }
}
