using System;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = n1;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n1; i++)
            {
                int currentNum1 = int.Parse(Console.ReadLine());
                sum1 += currentNum1;
            }
            for (int i = 0; i < n2; i++)
            {
                int currentNum2 = int.Parse(Console.ReadLine());
                sum2 += currentNum2;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
