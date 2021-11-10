using System;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            double nums = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;


            for (int i = 1; i <= nums; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum += currentNumber;
                    if (currentNumber >= oddMax)
                    {
                        oddMax = currentNumber;
                    }
                    if (currentNumber <= oddMin)
                    {
                        oddMin = currentNumber;
                    }
                }
                else if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                    if (currentNumber >= evenMax)
                    {
                        evenMax = currentNumber;
                    }
                    if (currentNumber <= evenMin)
                    {
                        evenMin = currentNumber;
                    }
                }
            }
            if (nums == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (nums <= 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {

                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }

    }
}
