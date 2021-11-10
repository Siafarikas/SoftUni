using System;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            int currentResult = 0;
            bool flag = false;

            for (int x = start; x <= end; x++)
            {
                for (int y = start; y <= end; y++)
                {
                    currentResult = x + y;
                    combinations++;
                    if (currentResult == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({x} + {y} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag !=true)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }

        }
    }
}
