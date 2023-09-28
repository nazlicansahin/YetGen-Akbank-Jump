using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Entities
{
    internal class Playlist
    {

        public Guid Id { get; set; }

        private List<Song> Songs { get; set; }

        private Random random;

        public Playlist(Song firstSong) 
        {
            // Songs = new List<string>();
            Id = Guid.NewGuid();

            Songs = new List<Song>();

            random = new();
            
            AddSong(firstSong);
        }

        public string GetSongs()
        {

            return string.Join("\n", Songs.Select(song =>$"{song.Title} - {song.Composer}"));

        //    StringBuilder stringBuilder = new StringBuilder();
        //
        //    foreach (Song song in Songs)
        //    {
        //        stringBuilder.Append($"Song: {song.Title} Composer: {song.Composer} \n");
        //    }
        //    return stringBuilder.ToString();
        }

        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        public void ShowSongs() { 
        
            foreach (Song song in Songs)
            {
                Console.WriteLine($"Title: {song.Title} - {song.Composer}");
            }
        }

        public void ShuffleSongs()
        {
            int n = Songs.Count;


            while (n > 0)
            {

                n--;

                Song song = Songs[n];


                int randomIndex = random.Next(n);

                Songs[n] = Songs[random.Next(n)];

              

                Songs[randomIndex] = song;

            }


        }
       



    }
}
