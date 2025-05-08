using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 6, 12, 7, 5, 9, 12, 3, 7, 1, 9, 3, 4 };
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

        Console.WriteLine("Unique numbers:");
        foreach ( int num in uniqueNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Total unique elements: " + uniqueNumbers.Count);
    }
}