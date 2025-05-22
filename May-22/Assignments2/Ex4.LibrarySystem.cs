using System;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int id, string title, string author, bool isAvailable = true)
    {
        Id = id;
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }

    public override string ToString()
    {
        return $"{Id}: \"{Title}\" by {Author} - {(IsAvailable ? "Available" : "Unavailable")}";
    }
}

class Library
{
    private List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();
    }

    public List<Book> SearchByTitle(string title)
    {
        return books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        //adding books
        library.AddBook(new Book(1, "Horror Village", "George"));
        library.AddBook(new Book(2, "Moral Values", "Stephen"));
        library.AddBook(new Book(3, "Victory Rules", "James"));

        //search by author
        Console.WriteLine("Search by author: 'Stephen'");
        var authorResults = library.SearchByAuthor("Stephen");
        foreach (var book in authorResults)
            Console.WriteLine(book);

        //search by title
        Console.WriteLine("\nSearch by title: 'Horror'");
        var titleResults = library.SearchByTitle("Horror");
        foreach ( var book in titleResults)
            Console.WriteLine(book);
       
    }
}