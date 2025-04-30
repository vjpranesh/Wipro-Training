using System;

public class HelloWorld
{
     public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int original = number;
        int reversed = 0;

        while (number != 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        Console.WriteLine("Reversed number: " + reversed);
    }
}