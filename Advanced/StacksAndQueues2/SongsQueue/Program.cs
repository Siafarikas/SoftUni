using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> playlist = new Queue<string>(songs);

            while (playlist.Count > 0)
            {
                string input = Console.ReadLine();
                string[] parts = input
                    .Split();
                string command = parts[0];
                if (command == "Play") 
                {
                    playlist.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = input.Substring(4);
                    if (playlist.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        playlist.Enqueue(song);
                    }
                }
                else
                {
                    Console.Write(string.Join(", ", playlist));
                    Console.WriteLine();
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
