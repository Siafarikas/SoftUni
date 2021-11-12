using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> nums = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string currNum = Console.ReadLine();
                if (nums.ContainsKey(currNum))
                {
                    nums[currNum]++;
                }
                else
                {
                    nums.Add(currNum, 1);
                }
            }
            foreach (var num in nums)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                    break;
                }
            }
        }
    }
}
