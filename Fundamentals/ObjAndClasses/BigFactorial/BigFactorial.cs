using System;
using System.Numerics;

namespace BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

        }
    }
}
