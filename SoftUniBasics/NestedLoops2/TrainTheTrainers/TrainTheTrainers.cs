using System;

namespace TrainTheTrainers
{
    class TrainTheTrainers
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double gradeSum = 0;
            double gradeSumStudent = 0;
            int count = 0;

            while (presentation != "Finish")
            {

                for (int i = 1; i <= judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                    gradeSumStudent += grade;
                }
                double averageGrade = gradeSum / judges;
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");
                gradeSum = 0;
                count++;
                presentation = Console.ReadLine();
            }
            if (presentation == "Finish")
            {
                double result = gradeSumStudent / (judges * count);
                Console.WriteLine($"Student's final assessment is {result:f2}.");
            }
        }
    }
}
