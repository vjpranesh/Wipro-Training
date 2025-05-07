using System;

class Program
{
    static string FindLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        return longestWord;
    }
    static void Main()
    {
        string input = "Learning C# is really interesting";
        string longest = FindLongestWord(input);
        Console.WriteLine(longest);
    }
}