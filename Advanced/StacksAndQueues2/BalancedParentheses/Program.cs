using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> skobi = new Stack<char>(input);
            bool isBalanced = true;

            for (int i = 0; i < skobi.Count / 2; i++)
            {
                if (skobi.Peek() == ']')
                {

                }
            }

        }
    }
}
