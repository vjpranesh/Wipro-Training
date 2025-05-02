using System;

class Program
{
    static void Main()
    {
        int[] input = { 1, 2, 3, 4, 5, 6, 7 };
        int[] factorials = ComputeFactorials(input, 0);

        Console.WriteLine(string.Join(", ", factorials));
    }
    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }
    static int[] ComputeFactorials(int[] arr, int index)
    {
        if (index >= arr.Length) return new int[arr.Length];
        int[] result = ComputeFactorials(arr, index + 1);
        result[index] = Factorial(arr[index]);
        return result;
    }
}
