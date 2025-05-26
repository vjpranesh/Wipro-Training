using System;
using System.Linq;

class Program
{
    static void Main()
    {

        string input = "C# is great. C# is powerful, Learning C# is fun,  It is used for web applications";

        var words = input
            .ToLower()
            .Split(new[] {' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        var wordCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        var top5 = wordCount
            .OrderByDescending(kvp => kvp.Value)
            .Take(5);

        Console.WriteLine("\nTop 5 most frequent words");
        foreach (var kvp in top5)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
        }
    }
}