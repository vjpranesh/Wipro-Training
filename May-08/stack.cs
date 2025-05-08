using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> books = new Stack<string>();

        books.Push("C# Programming");
        books.Push("Data Structure");
        books.Push("Machine Learning");

        Console.WriteLine("Books in the stack:");
        foreach ( var book in books)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine("\nPopped: " + books.Pop());

        Console.WriteLine("Next on the stack:" + books.Peek());
    }
}