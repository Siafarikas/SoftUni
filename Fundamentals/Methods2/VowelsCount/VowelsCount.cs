using System;

namespace VowelsCount
{
    class VowelsCount
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(CountsVowelsInWord(word));
        }

        static int CountsVowelsInWord(string word)
        {
            int vowelCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                switch (ch)
                {
                    case 'a':
                    case 'A':
                    case 'o':
                    case 'O':
                    case 'i':
                    case 'I':
                    case 'e':
                    case 'E':
                    case 'u':
                    case 'U':
                        vowelCount++;
                        break;
                    default:
                        break;
                }
            }
            return vowelCount;
        }
    }
}
