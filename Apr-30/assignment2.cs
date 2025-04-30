using System;

public class HelloWorld
{
     public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int sum = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                sum += c - '0'; 
            }
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}