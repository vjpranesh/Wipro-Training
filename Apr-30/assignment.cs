using System;

public class HelloWorld
{
     public static void Main(string[] args)
     {
        Console.Write("Enter a month number (1-12): ");
        int monthNumber;

        if (int.TryParse(Console.ReadLine(), out monthNumber))
        {
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                string monthName = new DateTime(2025, monthNumber, 1).ToString("MMMM");
                Console.WriteLine("Month name: " + monthName);
            }
            else
            {
                Console.WriteLine("Invalid month number. Please enter a number from 1 to 12.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
   
        
}