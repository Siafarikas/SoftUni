using System;
using System.Linq;
using System.Collections.Generic;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowels = new Queue<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));
            var consonants = new Stack<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));

            var words = new List<string>() { "pear", "flour", "pork", "olive" };
            var completedWords = new List<string>();


            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < vowels.Count; j++)
                {
                    words[i] = words[i].Replace(vowels.Peek(), '-');
                    vowels.Enqueue(vowels.Dequeue());
                }
            }
            for (int i = 0; i < words.Count; i++)
            {
                var oldConsonants = consonants;
                for (int j = 0; j < oldConsonants.Count; j++)
                {
                    words[i] = words[i].Replace(oldConsonants.Peek(), '-');
                    oldConsonants.Pop();
                }
            }

            if (words[0] == "----")
            {
                completedWords.Add("pear");
            }
            else if (words[1] == "-----")
            {
                completedWords.Add("flour");
            }
            else if (words[2] == "----")
            {
                completedWords.Add("pork");
            }
            else if (words[3] == "-----")
            {
                completedWords.Add("olive");
            }
        }
    }
}

