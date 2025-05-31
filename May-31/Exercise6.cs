using System;
using System.Collections.Generic;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(int id, string title)
    {
        Id = id;
        Title = title;
        IsBorrowed = false;
    }
}

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public Student(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
    }
}

class BorrowedRecord
{
    public Book Book { get; set; }
    public Student Student { get; set; }
    public DateTime DueDate { get; set; }
}

class Library
{
    private List<Book> books = new List<Book>();
    private List<Student> students = new List<Student>();
    private List<BorrowedRecord> borrowedRecords = new List<BorrowedRecord>();

    public void AddBook(Book book) => books.Add(book);

    public void DeleteBook(int id)
    {
        var book = books.Find(b => b.Id == id);
        if (book != null && !book.IsBorrowed)
        {
            books.Remove(book);
            Console.WriteLine("Book deleted");
        }
        
    }

    public void AddStudent(Student student) => students.Add(student);

    public void BorrowBook(int bookId, int studentId)
    {
        var book = books.Find(b => b.Id == bookId);
        var student = students.Find(s => s.StudentId == studentId);

        if (book == null || student == null)
        {
            Console.WriteLine("Invalid student ID");
            return;
        }

        if (book.IsBorrowed)
        {
            Console.WriteLine("Book is already borrowed");
            return;
        }

        book.IsBorrowed = true;
        var record = new BorrowedRecord
        {
            Book = book,
            Student = student,
            DueDate = DateTime.Now.AddDays(10)
        };
        borrowedRecords.Add(record);
        Console.WriteLine($"{student.Name} borrowed '{book.Title}', Due: {record.DueDate:yyyy-MM-dd}");
    }

    public void ShowBorrowedBooks()
    {
        Console.WriteLine("\nBorrowed Books:");
        foreach (var record in borrowedRecords)
        {
            Console.WriteLine($"'{record.Book.Title}' by {record.Student.Name}, Due: {record.DueDate:yyyy-MM-dd}");
        }
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("\nBooks in Library:");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Borrowed: {book.IsBorrowed}");
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddBook(new Book(1, "C#"));
        library.AddBook(new Book(2, "Moral Values"));
        library.AddStudent(new Student(101, "Alice"));
        library.AddStudent(new Student(102, "Bob"));

        library.ShowAllBooks();
        library.BorrowBook(1, 101);
        library.BorrowBook(2, 102);

        library.ShowBorrowedBooks();
        library.DeleteBook(1);
        library.ShowAllBooks();
    }
}
