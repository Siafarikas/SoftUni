using System;

namespace SumPrimeNonPrime
{
    class SumPrimeNonPrime
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        primeSum += number;
                    }
                    else
                    {
                        nonPrimeSum += number;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
