using System;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string result = Grade(num);
            Console.WriteLine(result);
        }


        static string Grade(double grade)
        {
            string output;
            if (grade < 3)
            {
                output = "Fail";
            }
            else if (grade < 3.50)
            {
                output = "Poor";
            }
            else if (grade < 4.50)
            {
                output = "Good";
            }
            else if (grade < 5.50)
            {
                output = "Very good";
            }
            else
            {
                output = "Excellent";
            }
            return output;
        }
    }
}
