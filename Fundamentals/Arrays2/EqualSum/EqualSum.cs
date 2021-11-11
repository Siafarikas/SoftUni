using System;
using System.Linq;

namespace EqualSum
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j < i)
                    {
                        leftSum += arr[j];
                    }
                    else if (j > i)
                    {
                        rightSum += arr[j];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                else if (i == arr.Length - 1)
                {
                    Console.WriteLine("no");
                    return;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
        }
    }
}
