using System;
using System.Collections.Generic;

namespace Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < countOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                string typeList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song newSong = new Song()
                {
                    Name = name,
                    TypeList = typeList,
                    Time = time,
                };

                songs.Add(newSong);
            }

            string type = Console.ReadLine();

            if (type == "all")
            {
                foreach (var song in songs)
                    Console.WriteLine(song.Name);
            }
            else
            {
                List<Song> filteredSongs = songs.FindAll(song => song.TypeList == type);
                foreach (var song in filteredSongs)
                    Console.WriteLine(song.Name);
            }
        }
    }
}
