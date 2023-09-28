
using Lesson3.Entities;
namespace Lesson3.Services
{
    internal class NotepadService
    {

        public void WriteToNotepad(Playlist playlist) {

            string directory = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\\Playlists";

            if( !File.Exists(directory) )
            
                Directory.CreateDirectory(directory);
            


            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");

            File.WriteAllText(saveFile, playlist.GetSongs());
        
        //Saving to Notepad...
        Console.WriteLine("Successfull");

        
        }
    }
}
