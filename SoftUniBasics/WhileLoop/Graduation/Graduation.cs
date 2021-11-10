using System;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int class1 = 1;
            double totalGrades = 0;
            while (class1 <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    totalGrades += grade;
                    class1++;
                    continue;
                }
                else
                {
                    totalGrades += grade;
                    if (grade >= 4)
                    {
                        totalGrades += grade;
                        class1++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been excluded at {class1} grade");
                        break;
                    }
                }
            }
            if (class1 > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {totalGrades / 12:f2}");

            }
        }
    }
}
