using System;

namespace StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentFact = 1;
            int numberDigit = number;

            while (sum != number)
            {
                int digit = numberDigit % 10;
                for (int j = 1; j <= digit; j++)
                {
                    currentFact = currentFact * j;
                }
                sum += currentFact;
                currentFact = 1;
                numberDigit = numberDigit / 10;
                if (numberDigit <= 0)
                {
                    break;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
