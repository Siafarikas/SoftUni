using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = set[0];
            int m = set[1];
            HashSet<int> first = new HashSet<int>(n);
            HashSet<int> second = new HashSet<int>(m);
            HashSet<int> final = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var num in first)
            {
                if (second.Contains(num))
                {
                    final.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", final));
        }
    }
}
