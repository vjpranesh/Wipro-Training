using System;
using System.Diagnostics;

class SortingComparison
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(",", arr));
    }
    static void Main()
    {
        Random rand = new Random();
        int[] original = new int[20];
        for (int i = 0; i < original.Length; i++)
        {
            original[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Original Array:");
        PrintArray(original);

        // Bubble sort 
        int[] bubbleArray = (int[])original.Clone();
        Stopwatch sw = Stopwatch.StartNew();
        BubbleSort(bubbleArray);
        sw.Stop();
        Console.WriteLine("\nBubble Sort Result:");
        PrintArray(bubbleArray);
        Console.WriteLine($"Timetaken:{sw.ElapsedMilliseconds}  ms");

        // Selection sort 
        int[] selectionArray = (int[])original.Clone();
        sw.Restart();
        SelectionSort(selectionArray);
        sw.Stop();
        Console.WriteLine("\nSelection Sort Result:");
        PrintArray(selectionArray);
        Console.WriteLine($"Timetaken: {sw.ElapsedMilliseconds} ms");

        // Insertion sort 
        int[] insertionArray = (int[])original.Clone();
        sw.Restart();
        InsertionSort(insertionArray);
        sw.Stop();
        Console.WriteLine("\nInsertion Sort Result:");
        PrintArray(insertionArray);
        Console.WriteLine($"Timetaken: {sw.ElapsedMilliseconds} ms");

        Console.WriteLine("\nTime Complexity:");
        Console.WriteLine("Bubble Sort: O(n^2)");
        Console.WriteLine("Selection Sort: O(n^2)");
        Console.WriteLine("Insertion Sort: O(n^2)");
    }
}

    
