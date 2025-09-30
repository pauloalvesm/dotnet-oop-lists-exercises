namespace OOP.Lists.Exercise07.Models;

public class Song
{
    public string Name { get; private set; }
    public string Artist { get; private set; }
    public string RecordLabel { get; private set; }

    public Song(string name, string artist, string recordLabel)
    {
        Name = name;
        Artist = artist;
        RecordLabel = recordLabel;
    }
}
