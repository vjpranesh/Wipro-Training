using System;

class Program
{
    static int Mul(int a, int b)
    {
        return a * b;
    }

    static double Mul(double a, double b)
    {
        return a * b;
    }

    static void Main()
    {
        Console.WriteLine("Int Mul: " + Mul(3, 4));
        Console.WriteLine("Double Mul: " + Mul(2.5, 4.3));
    }
}
