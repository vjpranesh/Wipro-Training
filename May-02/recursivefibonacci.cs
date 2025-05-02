using System;

class Program
{
    static void Main()
    {
        int count = 40;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(Fibonacci(i) + " ");
        }
    }
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
