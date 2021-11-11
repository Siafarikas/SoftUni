using System;

namespace Encrypt
{
    class Encrypt
    {
        static void Main(string[] args)
        {
            int strings = int.Parse(Console.ReadLine());
            int[] output = new int[strings];

            for (int i = 0; i < strings; i++)
            {
                int vowelSum = 0;
                int conSum = 0;
                string input = Console.ReadLine();
                foreach (char c in input)
                {
                    switch (c)
                    {
                        case 'a':
                        case 'e':
                        case 'o':
                        case 'u':
                        case 'i':
                            vowelSum += (int)c * input.Length;
                            break;
                        default:
                            conSum += (int)c / input.Length;
                            break;
                    }
                }
                output[i] = vowelSum + conSum;
            }
            Array.Sort(output);
            foreach (int item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
