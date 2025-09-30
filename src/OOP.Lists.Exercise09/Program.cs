using OOP.Lists.Exercise09.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******** Book ********");

        Console.WriteLine("Enter the Book data: ");
        
        Console.Write("Title: ");
        string bookTitle = Console.ReadLine();
   
        Console.Write("Author: ");
        string authorName = Console.ReadLine();

        Console.WriteLine("\n-------- Result --------");

        try
        {
            Book book = new Book(bookTitle, authorName);
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine($"Error: {exception.Message}");
        }

        Console.ReadKey();
    }
}