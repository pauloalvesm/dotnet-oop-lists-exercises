using OOP.Lists.Exercise07.Business;
using OOP.Lists.Exercise07.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Welcome to your playlist! *****");

        Console.Write("Enter the playlist owner's name: ");
        string playlistOwner = Console.ReadLine();
        Playlist myPlaylist = new Playlist(playlistOwner);

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1 - Add song");
            Console.WriteLine("2 - Play random song");
            Console.WriteLine("3 - Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the song name: ");
                string name = Console.ReadLine();

                Console.Write("Enter the artist name: ");
                string artist = Console.ReadLine();

                Console.Write("Enter the record label name: ");
                string recordLabel = Console.ReadLine();

                Song newSong = new Song(name, artist, recordLabel);
                myPlaylist.AddSong(newSong);
            }
            else if (choice == "2")
            {
                myPlaylist.PlayRandomSong();
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }

    }
}