using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());

            double mostLectures = 0;
            double maxPoints = 0;

            for (int i = 0; i < studentCount; i++)
            {
                double lectures = double.Parse(Console.ReadLine());

                if (mostLectures <= lectures)
                {
                    mostLectures = lectures;
                }
               maxPoints = (mostLectures / lecturesCount) * (5 + additionalBonus);
            }


            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxPoints)}.");
            Console.WriteLine($"The student has attended {mostLectures} lectures.");

        }
    }
}
