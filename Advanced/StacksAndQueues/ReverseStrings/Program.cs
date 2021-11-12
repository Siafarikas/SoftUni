using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> str = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                str.Push(input[i]);
            }

            while (str.Count > 0)
            {
                Console.Write(str.Pop());
            }
        }
    }
}
