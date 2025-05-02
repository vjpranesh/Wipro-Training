using System;

class Program
{
    static void BubbleSort(int [] arr)
    {
        int n = arr.Length;
        for ( int i = 0; i < n; i++)
        {
            for ( int j =0; j < n - 1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    //swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }
    //print array method
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.WriteLine(num + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] numbers = {64,25,12,22,11};
        Console.WriteLine("Original array");
        PrintArray(numbers);
        BubbleSort(numbers);
        Console.WriteLine("Sorted Array");
         PrintArray(numbers);
        
    }
}