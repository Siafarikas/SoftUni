using System;

namespace ExamPreparation
{
    class ExamPreparation
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string inputProblem = "";
            double sumGrades = 0;
            int problems = 0;
            int badGradesCount = 0;
            string lastProblem = "";


            while (badGradesCount < badGrades)
            {
                inputProblem = Console.ReadLine();
                if (inputProblem == "Enough")
                {
                    break;
                }
                lastProblem =inputProblem;
                int inputGrade = int.Parse(Console.ReadLine());
                sumGrades += inputGrade;
                problems++;
                if (inputGrade <= 4)
                {
                    badGradesCount++;
                }
            }
            if (inputProblem == "Enough")
            {
                Console.WriteLine($"Average score: {sumGrades / problems:f2}");
                Console.WriteLine($"Number of problems: {problems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
        }
    }
}
