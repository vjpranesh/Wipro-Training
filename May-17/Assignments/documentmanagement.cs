using System;

abstract class Document
{
    public abstract void PrintContent();
    public void ShowDocumentType(string type)
    {
        Console.WriteLine($"Document Type: {type}");
    }
}

class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word Document");
    }
}

class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing PDF document");
    }
}

class Program
{
    static void Main()
    {
        Document wordDoc = new WordDocument();
        Document PDFdoC = new PDFDocument();

        wordDoc.ShowDocumentType("Word");
        wordDoc.PrintContent();

        PDFdoC.ShowDocumentType("PDF");
        PDFdoC.PrintContent();
    }
}