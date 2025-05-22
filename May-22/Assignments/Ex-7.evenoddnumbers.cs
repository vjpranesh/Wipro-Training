using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main()
    {
        //list with at least 10 numbers
        List<int> numbers = new List<int> { 2, 5, 12, 7, 9, 4, 3, 18, 6, 11, 14, 20, 24, 27 };

        //filter odd and even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

        Console.WriteLine("Even Numbers:");
        foreach ( var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n\nOdd Numbers:");
        foreach ( var num in  oddNumbers)
        {
            Console.Write(num + " ");
        }
    }
}
