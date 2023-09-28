using Lesson3.Entities;
using Lesson3.Services;

Console.WriteLine("Stopify - Music for Noone");

//string currentDirectory = Directory.GetCurrentDirectory(); bulundugun klasorun yolu
//string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()); bulundugun klasorun bir ustu
//string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent; bulundugun klasorun 3 ustu yolu
//string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?; bulundugun klasorun 3 ustu yoluna ulasamazsa null doner


var song1 = new Song("Mozart","requem", "Orch nat de France", null);

var song2 = new Song("artist2", "Title 2", "Produce2", "composer2");

var song3 = new Song("artist3", "Title 3", "Produce2", "composer3");

var song4 = new Song("artist4", "Title 4", "Produce4", "composer4");


var playlist1 = new Playlist(song1);

playlist1.AddSong(song2);

 Console.WriteLine(playlist1.GetSongs());

NotepadService notepadService = new NotepadService();

notepadService.WriteToNotepad(playlist1.GetSongs());