using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Random random = new Random();
        ArrayList numbers = new ArrayList();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(1, 51));
        }
        numbers.Sort();

        Console.WriteLine("Sorted Numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num + " ");
        }
        Console.WriteLine();

        int min = (int)numbers[0];
        int max = (int)numbers[numbers.Count - 1];

        Console.WriteLine("Minimum: " + min);
        Console.WriteLine("Maximium: " + max);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = (double)sum / numbers.Count;
        Console.WriteLine("Average:" + average);
    }
}