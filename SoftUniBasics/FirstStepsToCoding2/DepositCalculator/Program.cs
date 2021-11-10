using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double overallRate = deposit * annualInterestRate / 100;
            double monthlyRate = overallRate / 12;
            double finalSum = deposit + (term * monthlyRate);
            Console.WriteLine(finalSum);
        }
    }
}
