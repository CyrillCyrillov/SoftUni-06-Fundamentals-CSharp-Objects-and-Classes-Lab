﻿using System;
using System.Collections.Generic;

namespace Task03_Songs
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
            int numberOfSong = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            
            for (int i = 1; i <= numberOfSong; i++)
            {
                string[] songData = Console.ReadLine().Split('_');

                string type = songData[0];
                string name = songData[1];
                string time = songData[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if(typeList == "all")
            {
                foreach(Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach(Song song in songs)
                {
                    if(song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }

            }
        }
    }
}
