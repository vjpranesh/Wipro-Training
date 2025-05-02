using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        int result = SumOfDigits(numbers, 0);
        Console.WriteLine("Sum of digits using recursion: " + result);
    }
    static int SumOfDigits(int[] arr, int index)
    {
        if (index >= arr.Length)
            return 0;
        return arr[index] + SumOfDigits(arr, index + 1);
    }
}
