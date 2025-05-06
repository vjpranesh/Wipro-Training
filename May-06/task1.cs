using system;

class Program
{
    static int CountWords(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    static void Main()
    {
        string sentence = "Learning C# is fun";
        int wordCount = CountWords(sentence);
        Console.WriteLine($"{wordCount} words");
    }
}