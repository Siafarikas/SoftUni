using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < nums; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber >= maxNum)
                {
                    maxNum = currentNumber;
                }
            }

            sum -= maxNum;

            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}
