using System;
using System.Linq;
using System.Text;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string unwanted = Console.ReadLine().ToLower();
            string word = Console.ReadLine();

            while (word.Contains(unwanted))
            {
                int idx = word.IndexOf(unwanted);
                word = word.Remove(idx, unwanted.Length);
            }
            Console.WriteLine(word);
        }
    }
}
