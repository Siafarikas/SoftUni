using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            nums.Sort();
            nums.Reverse();
            for (int i = 0; i < nums.Count; i++)
            {
                int printed = nums[i];
                Console.Write($"{printed} ");
                if (i == 2)
                {
                    break;
                }
            }

        }
    }
}
