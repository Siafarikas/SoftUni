using System;
using System.Collections.Generic;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blackList = Console.ReadLine()
                .Split(", ")
                .ToList();

            string text = Console.ReadLine();

            foreach (var word in blackList)
            {
                if (text.Contains(word))
                {
                    int idx = text.IndexOf(word);
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
