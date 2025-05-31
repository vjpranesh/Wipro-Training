using System;

class Calculator
{
    //add
    public static int Add(int a, int b) => a + b;
    public static float Add(float a, float b) => a + b;
    public static double Add(double a, double b) => a + b;

    //sub
    public static int Subtract(int a, int b) => a - b;
    public static float Subtract(float a, float b) => a - b;
    public static double Subtract(double a, double b) => a - b;

    //mul
    public static int Multiply(int a, int b) => a * b;
    public static float Multiply(float a, float b) => a * b;
    public static double Multiply(double a, double b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose operation: Add / Subtract / Multiply");
        string op = Console.ReadLine().ToLower();

        Console.WriteLine("Enter data type: int / float / double");
        string type = Console.ReadLine().ToLower();

        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();

        if (type == "int")
        {
            int a = int.Parse(input1);
            int b = int.Parse(input2);
            ShowResult(op, a, b);
        }
        else if (type == "float")
        {
            float a = float.Parse(input1);
            float b = float.Parse(input2);
            ShowResult(op, a, b);
        }
        else if (type == "double")
        {
            double a = double.Parse(input1);
            double b = double.Parse(input2);
            ShowResult(op, a, b);
        }
        else
        {
            Console.WriteLine("Invalid type.");
        }
    }

    static void ShowResult(string op, int a, int b)
    {
        if (op == "add") Console.WriteLine("Result: " + Calculator.Add(a, b));
        else if (op == "subtract") Console.WriteLine("Result: " + Calculator.Subtract(a, b));
        else if (op == "multiply") Console.WriteLine("Result: " + Calculator.Multiply(a, b));
        else Console.WriteLine("Invalid operation");
    }

    static void ShowResult(string op, float a, float b)
    {
        if (op == "add") Console.WriteLine("Result: " + Calculator.Add(a, b));
        else if (op == "subtract") Console.WriteLine("Result: " + Calculator.Subtract(a, b));
        else if (op == "multiply") Console.WriteLine("Result: " + Calculator.Multiply(a, b));
        else Console.WriteLine("Invalid operation");
    }

    static void ShowResult(string op, double a, double b)
    {
        if (op == "add") Console.WriteLine("Result: " + Calculator.Add(a, b));
        else if (op == "subtract") Console.WriteLine("Result: " + Calculator.Subtract(a, b));
        else if (op == "multiply") Console.WriteLine("Result: " + Calculator.Multiply(a, b));
        else Console.WriteLine("Invalid operation");
    }
}
