using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string specialBomb = Console.ReadLine();
            string[] parts = specialBomb.Split();
            int specialBombNum = int.Parse(parts[0]);
            int radiusExplosion = int.Parse(parts[1]);

            while (numbers.Contains(specialBombNum))
            {
                int bombIndex = numbers.IndexOf(specialBombNum);
                int start = bombIndex - radiusExplosion;
                int count = 2 * radiusExplosion + 1;

                if (start < 0)
                {
                    start = 0;
                }
                if (count >= numbers.Count)
                {
                    count = numbers.Count - (numbers.Count - bombIndex);
                }
                numbers.RemoveRange(start, count);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
