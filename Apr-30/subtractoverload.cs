using System;

class Program
{
    static int Sub(int a, int b)
    {
        return a - b;
    }

    static double Sub(double a, double b)
    {
        return a - b;
    }

    static void Main()
    {
        Console.WriteLine("Int Sub: " + Sub(3, 4));
        Console.WriteLine("Double Sub: " + Sub(2.5, 4.3));
    }
}
