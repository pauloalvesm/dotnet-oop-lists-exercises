namespace OOP.Lists.Exercise09.Models;

public class Book
{
    private string _title;
    private string _author;

    public Book(string title, string author)
    {
        ValidateData(title, author);
        _title = title;
        _author = author;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    private void ValidateData(string title, string name)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("The book title cannot be empty or null!");
        }
        else if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("The author name cannot be empty or null!");
        }
    }
}
