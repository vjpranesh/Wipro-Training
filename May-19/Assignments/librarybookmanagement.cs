using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
    public void PirntInfo()
    {
        Console.WriteLine($"Title : {Title}, Author: { Author}");
    }
}

class Program
{
    static void Main()
    {
        //queue for borrowed books
        Queue<Book> borrowedBooks = new Queue<Book>();

        borrowedBooks.Enqueue(new Book("Mystery", "Williams"));
        borrowedBooks.Enqueue(new Book("Victory Rules","George"));
        borrowedBooks.Enqueue(new Book("The Justice ", "Justine"));
        borrowedBooks.Enqueue(new Book("Political Rules", "Bentick"));
        borrowedBooks.Enqueue(new Book("Lion King","James"));

        Console.WriteLine("Next book to be returned:");
        borrowedBooks.Peek().PirntInfo();

        Console.WriteLine("\nReturning the book..");
        borrowedBooks.Dequeue();

        // stack for newly purchased books
        Stack<Book> newBooks = new Stack<Book>();

        newBooks.Push(new Book("Village Horror", "Paul"));
        newBooks.Push(new Book("Moral Values", "Stephen"));
        newBooks.Push(new Book("Good Habbits", "James"));

        Console.WriteLine("\nLast book purchased:");
        newBooks.Peek().PirntInfo();

        Console.WriteLine("\nProcessing the last purchased book...");
        newBooks.Pop();

        //print remaining borrowed books
        Console.WriteLine("\nRemaining borrowed books:");
        foreach (var book in borrowedBooks)
        {
            book.PirntInfo();
        }

        //print remaining new books
        Console.WriteLine("\nRemaining new books:");
        foreach (var book in newBooks)
        {
            book.PirntInfo();
        }
    }
}