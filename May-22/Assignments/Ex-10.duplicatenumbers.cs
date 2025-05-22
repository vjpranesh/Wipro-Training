using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main()
    {
        // list with repeated numbers
        List<int> numbers = new List<int> { 3, 5, 6, 5, 7, 1, 3, 5, 8, 9, 2 };

        //find numbers appear more than once
        var duplicates = numbers
            .GroupBy(n => n)
            .Where( g => g.Count() > 1)
            .Select( g => g.Key)
            .ToList();

        Console.WriteLine("duplicates");
        foreach ( var num in duplicates )
        {
            Console.WriteLine(num);
        }
    }
}
