using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main()
    {
        string sentence = " C# is great and C# is fun";

        var words = sentence
            .ToLower()
            .Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries );

        var wordGroups = words
            .GroupBy(w => w)
            .Select(g => new { Word = g.Key, Count = g.Count() });

        Console.WriteLine("Word counts:");
        foreach ( var group in wordGroups)
        {
            Console.WriteLine($"{group.Word}: {group.Count}");
        }
    }
}
