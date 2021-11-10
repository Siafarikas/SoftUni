using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    int currentNum = int.Parse(Console.ReadLine());
                    sum1 += currentNum;
                }
                else if (i % 2 == 0)
                {
                    int currentNum = int.Parse(Console.ReadLine());
                    sum2 += currentNum;
                }
            }
            
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
