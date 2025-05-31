using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph");
        string input = Console.ReadLine();

        string cleaned = new string(input
            .ToLower()
            .Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
            .ToArray());

        string[] words = cleaned.Split(new[] { ' ','\t','\n'}, StringSplitOptions.RemoveEmptyEntries);

        var wordFrequency = words
            .GroupBy(w => w)
            .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("\nWord Frequencies");
        foreach ( var pair in wordFrequency.OrderByDescending( p => p.Value))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        //vowels and consonant 
        int vowels = 0, consonants = 0;
        foreach (char c in cleaned)
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine($"\nTotal Vowels: {vowels}");
        Console.WriteLine($"Total Consonants: {consonants}");

        string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
        string shortestWord = words.OrderBy( w => w.Length).FirstOrDefault();

        Console.WriteLine($"\nLongest Word: {longestWord}");
        Console.WriteLine($"\nShortest Word: {shortestWord}");
    }
}