using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > sum)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
