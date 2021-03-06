using System;
using System.Collections.Generic;

namespace Songs
{
    class Songs
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < num; i++)
            {
                string[] data = Console.ReadLine()
                    .Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song()
                {
                    TypeList = type,
                    Name = name,
                    Time = time
                };

                songs.Add(song);
            }

            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}

public class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public int Time { get; set; }

}

