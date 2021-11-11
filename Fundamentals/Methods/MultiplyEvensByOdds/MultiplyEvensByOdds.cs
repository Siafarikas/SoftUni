using System;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetProductOfEvenAndOdd(number));
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            number = Math.Abs(number);
            while (number != 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }
                number = number / 10;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            number = Math.Abs(number);
            while (number != 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 1)
                {
                    oddSum += currentDigit;
                }
                number = number / 10;
            }
            return oddSum;
        }
        static int GetProductOfEvenAndOdd(int number)
        {
            int result = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            return result;
        }


    }
}
