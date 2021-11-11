using System;

namespace TribonacciSequence
{
    class TribonacciSequence
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            foreach (var item in TribonacciNums(num))
            {
                Console.Write($"{item} ");
            }
        }

        static int[] TribonacciNums(int num)
        {
            int[] arr = new int[num];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;

            for (int i = 3; i < num; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }
            return arr;
        }
    }
}
