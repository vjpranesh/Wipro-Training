using System;

class Program
{
    static void PrintSquares(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int square = arr[i] * arr[i];
            Console.WriteLine($"Element {i + 1}: {arr[i]}, Square: {square}");
        }
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        PrintSquares(numbers);
    }
}
