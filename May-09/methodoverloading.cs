//calculator.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Calculator
    {
        // Addition overloading // Method overloading 
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        //subtraction overlaoding
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public int Sub(int a, int b, int c)
        {
            return (a - b) + c;
        }

        //multiplication overloading 
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public int Mul(int a, int b, int c)
        {
            return a * b + c;
        }


    }   
}



//program.cs

using ConsoleApp3;
using System;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Addition:");
        Console.WriteLine("2 + 3 = " + calc.Add(2, 3));
        Console.WriteLine("2.5 + 3.7 =  " + calc.Add(2.5, 3.7));
        Console.WriteLine("1 + 2 + 3 = " + calc.Add(1, 2, 3));

        Console.WriteLine("Subtraction:");
        Console.WriteLine("7 - 3 = " + calc.Sub(7, 3));
        Console.WriteLine("7.5 - 2.7 =  " + calc.Sub(7.5, 2.7));
        Console.WriteLine("1 - 2 + 3 = " + calc.Sub(1, 2, 3));

        Console.WriteLine("Multiplication:");
        Console.WriteLine("2 * 3 = " + calc.Mul(2, 3));
        Console.WriteLine("2.5 * 3.7 =  " + calc.Mul(2.5, 3.7));
        Console.WriteLine("1 * 2 + 3 = " + calc.Mul(1, 2, 3));


    }
}