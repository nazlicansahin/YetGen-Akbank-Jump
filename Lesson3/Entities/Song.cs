using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Entities
{
    internal class Song
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Producer { get; set; }

        public string Composer { get; set; }

        public string Artist { get; set; }

        public Song() 
        { 
        
            Id = Guid.NewGuid();
        
        }

        public Song(string artist, string title, string producer, string composer)
        {

            Artist = artist;

            Title = title;

            Producer = producer;

            Composer = composer;

        }
    }
}
