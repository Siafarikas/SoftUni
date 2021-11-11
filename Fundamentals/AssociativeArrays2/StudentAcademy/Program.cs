using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double> { grade });
                }
                else
                {
                    students[studentName].Add(grade);
                }
            }

            Dictionary<string, double> studentsAvg = new Dictionary<string, double>();
            foreach (var student in students)
            {
                double sumGrade = 0;
                foreach (var grade in student.Value)
                {
                    sumGrade += grade;
                }
                double avgGrade = sumGrade / student.Value.Count;
                studentsAvg.Add(student.Key, avgGrade);
            }

            studentsAvg = studentsAvg
                .Where(i => i.Value >= 4.50)
                .OrderByDescending(i => i.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in studentsAvg)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
