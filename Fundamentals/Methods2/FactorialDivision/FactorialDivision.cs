using System;

namespace FactorialDivision
{
    class FactorialDivision
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{CalculatesDivisionOfTwoFactorials(num1, num2):f2}"); 
        }

        static double CalculatesDivisionOfTwoFactorials(double num1, double num2)
        {
            double factorial1 = 1;
            for (int i = 1; i <= num1; i++)
            {
                factorial1 *= i;
            }

            double factorial2 = 1;
            for (int i = 1; i <= num2; i++)
            {
                factorial2 *= i;
            }

            double result = factorial1 / factorial2;
            return result;
        }
    }
}
