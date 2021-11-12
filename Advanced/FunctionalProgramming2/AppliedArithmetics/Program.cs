using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Action<int[]> printer = num => Console.WriteLine(string.Join(" ", nums));

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                if (command == "add")
                {
                    nums = ForEach(nums, (num) => ++num);
                }
                else if (command == "multiply")
                {
                    nums = ForEach(nums, (num) => num * 2);
                }
                else if (command == "subtract")
                {
                    nums = ForEach(nums, (num) => --num);
                }
                else if (command == "print")
                {
                    printer(nums);
                }
            }
        }

        public static int[] ForEach(int[] nums, Func<int, int> func)
        {
            return nums
                .Select(num => func(num))
                .ToArray();
        }

    }
}
