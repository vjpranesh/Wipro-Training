using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main()
    {
        //list with names 
        List<string> names = new List<string>
        {
            "Bob", "Ram", "Sneha", "Reena", "Arun", "Umar", "Oviya", "Eswar", "Rohit", "Kumar"
        };

        //linq to find names strting with vowels
        var vowels = new[] { 'A', 'E', 'I', 'O', 'U' };

        var filteredNames = names
            .Where(name => vowels.Contains(char.ToUpper(name[0])))
            .OrderByDescending(name => name);

        Console.WriteLine("Names starting with vowel:");
        foreach ( var name in filteredNames)
        {
            Console.WriteLine(name);
        }
    }
}
