using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 1, 3, 2, 1 };
        bool[] counted = new bool[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (counted[i])
                continue;

            int count = 1;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    counted[j] = true;
                }
            }

            Console.WriteLine($"{arr[i]} occurs {count} time{(count > 1 ? "s" : "")}");
        }
    }
}
