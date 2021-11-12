using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == '(')
                {
                    brackets.Push(i);
                }
                else if (currentChar == ')')
                {
                    int startIdx = brackets.Pop();
                    int endIdx = i + 1;
                    Console.WriteLine(input.Substring(startIdx, endIdx - startIdx));
                }
            }
        }
    }
}
