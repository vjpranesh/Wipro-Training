using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 1 };
        int[] result = new int[arr.Length];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            bool exists = false;

            for (int j = 0; j < index; j++)
            {
                if (arr[i] == result[j])
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                result[index] = arr[i];
                index++;
            }
        }

        Console.WriteLine("Array without duplicates:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}
