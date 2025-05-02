using System;

class Program
{
    static void Main()
    {
        string input = "racecar";
        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        if (input == reversed)
            Console.WriteLine($"{input} is a palindrome");
        else
            Console.WriteLine($"{input} is not a palindrome");
    }
}

