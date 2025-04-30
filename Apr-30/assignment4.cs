using System;

public class HelloWorld
{
     public static void Main(string[] args)
    {
        int number = 1;

        while (true)
        {
            int square = number * number;

            if (square > 100)
                break;

            Console.WriteLine($"Number: {number}, Square: {square}");
            number++;
        }
    }
}