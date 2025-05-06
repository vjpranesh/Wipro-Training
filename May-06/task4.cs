using System;

class Program
{
    static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for 9int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int n = 4;
        PrintTriangle(n);
    }
}