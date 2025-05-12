using System;

interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    int Divide(int a, int b);

}

class SimpleCalculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public int Divide(int a, int b)
    {
        return a / b;  
    }
}

class Program
{
    static void Main()
    {
        SimpleCalculator calculator = new SimpleCalculator();

        Console.WriteLine("Add: " + calculator.Add(5, 5));
        Console.WriteLine("Subtract: " + calculator.Subtract(8, 5));
        Console.WriteLine("Multiply: " + calculator.Multiply(10, 3));
        Console.WriteLine("Divide: " + calculator.Divide(20, 5));

    }
}