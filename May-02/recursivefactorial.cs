using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        long result = RecursiveFactorial(numbers, numbers.Length - 1);
        Console.WriteLine($"Factorial: {result}");
    }
    static long RecursiveFactorial(int[] arr, int index)
    {
        if (index < 0)
            return 1;
        return arr[index] * RecursiveFactorial(arr, index - 1);
    }
}
