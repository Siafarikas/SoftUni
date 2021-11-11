using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Sign(num1, num2, num3));
        }

        static string Sign(int num1, int num2, int num3)
        {
            int positiveNums = 0;
            int negativeNums = 0;
            bool isZero = false;
            int[] array = { num1, num2, num3 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    positiveNums++;
                }
                else if (array[i] == 0)
                {
                    isZero = true;
                }
                else
                {
                    negativeNums++;
                }
            }

            if (isZero == true)
            {
                return "zero";
            }
            else if (positiveNums == 3 || positiveNums == 1)
            {
                return "positive";
            }
            else
            {
                return "negative";
            }
        }
    }
}
