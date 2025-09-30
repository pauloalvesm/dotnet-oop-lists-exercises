using OOP.Lists.Exercise07.Models;

namespace OOP.Lists.Exercise07.Business;

public class Playlist
{
    private List<Song> songList = new List<Song>();

    public string Owner { get; private set; }

    public Playlist(string owner)
    {
        Owner = owner;
    }

    public void AddSong(Song song)
    {
        songList.Add(song);
    }

    public void PlayRandomSong()
    {
        if (songList.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(songList.Count);
            Song playedSong = songList[randomIndex];
            Console.WriteLine($"Playing song: {playedSong.Name} - {playedSong.Artist}");
        }
        else
        {
            Console.WriteLine("The playlist is empty. Add songs before playing.");
        }
    }
}