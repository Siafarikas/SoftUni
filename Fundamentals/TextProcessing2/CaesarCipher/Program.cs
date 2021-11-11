using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int letterCode = input[i] + 3;
                string charac = char.ConvertFromUtf32(letterCode);
                sb.Append(charac);
            }
            Console.WriteLine(sb);
        }
    }
}
