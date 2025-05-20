using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class SearchComparison
{
    static int LinearSearch(int[] arr, int key , out int comparisons)
    {
        comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
                return i;
        }
        return -1;
    }
    static int BinarySearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            comparisons++;
            int mid = (low + high) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                low = mid + 1; 
            else
                high = mid - 1;

        }
        return -1;
    }
    static void Main()
    {
        //sorted list of 50 integers between 1 and 200
        Random rand = new Random();
        int[] arr = new int[50];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 200);
        }
        Array.Sort(arr);

        int key = arr[rand.Next(0, arr.Length)];

        Console.WriteLine($"Searching for: {key}");

        //Linear Search
        int linearComparisons;
        int linearIndex = LinearSearch(arr, key, out linearComparisons);
        Console.WriteLine($"\nLinear Search:");
        Console.WriteLine($"Position: {linearIndex}");
        Console.WriteLine($"Comparisons: {linearComparisons}");


        //Binary Search
        int binaryComparisons;
        int binaryIndex = BinarySearch(arr, key, out binaryComparisons);
        Console.WriteLine($"\nBinary Search:");
        Console.WriteLine($"Position: {binaryIndex}");
        Console.WriteLine($"Comparisons: {binaryComparisons}");


        // efficiency comparison
        Console.WriteLine($"\nEfficiency Comparison:");
        Console.WriteLine("Linear Search : O(n)");
        Console.WriteLine("Binary Search: O(log n)");

    }
}