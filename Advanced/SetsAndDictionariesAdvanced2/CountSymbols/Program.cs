using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> count = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (count.ContainsKey(input[i]))
                {
                    count[input[i]]++;
                }
                else
                {
                    count.Add(input[i], 1);
                }
            }
            count = count
                .OrderBy(x => x.Key)
                .ToDictionary(x=> x.Key, x=> x.Value);

            foreach (var symbol in count)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
