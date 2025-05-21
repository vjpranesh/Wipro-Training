//Hashing - first non repeating character

using System;
using System.Diagnostics.Tracing;

class Program
{
    static string FirstNonRepeatingChar(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency[c] = 1;
        }
        foreach (char c in input)
        {
            if (frequency[c] == 1)
                return c.ToString();
        }
        return "None";
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a string:");
        string input = Console.ReadLine();

        string  result = FirstNonRepeatingChar(input);
        if (result != "None")
            Console.WriteLine("First character that appears only once: " + result);
        else
            Console.WriteLine("No charcter found ");
             
    }
}
