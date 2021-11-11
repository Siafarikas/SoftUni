using System;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int fibonachiNum = 0;
            int[] initialArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == 1)
                {
                    initialArray[i] = 1;
                }
                else
                {
                    initialArray[i] = initialArray[i - 2] + initialArray[i - 1];
                }
                fibonachiNum = initialArray[i];
            }
            Console.WriteLine(fibonachiNum);
        }
    }
}
