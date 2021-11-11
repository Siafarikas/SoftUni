using System;
using System.Collections.Generic;
using System.Linq;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine()
                .Split(">")
                .ToList();

            List<string> output = new List<string>();

            int remainderPower = 0;
            output.Add(strings[0]);
            for (int i = 1; i < strings.Count; i++)
            {
                string currentString = strings[i];
                int explosionPower = (currentString[0] - '0') + remainderPower;
                if (explosionPower <= currentString.Length)
                {
                    currentString = currentString.Remove(0, explosionPower);
                    output.Add(currentString);
                }
                else
                {
                    remainderPower += explosionPower - currentString.Length;
                    currentString = currentString.Remove(0, currentString.Length);
                    output.Add(currentString);
                }
            }

            Console.WriteLine(string.Join('>' , output));
        }
    }
}
