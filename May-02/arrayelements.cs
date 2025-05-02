using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        PrintArray(numbers, 0);
    }
    static void PrintArray(int[] arr, int index)
    {
        if (index >= arr.Length)
            return;
        Console.Write(arr[index] + " ");
        PrintArray(arr, index + 1);
    }
}
