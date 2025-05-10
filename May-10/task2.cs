using System;

class PowerCalculation
{
    //calculation for integers
    public int Power(int baseValue, int exponent)
    {
        int result = 1;
        for ( int i = 0; i < exponent; i++)
        {
            result *= baseValue;
        }
        return result;
    }

    //calculation for doubles
    public double Power(double baseValue, int exponent)
    {
        double result = 1.0;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseValue;
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        PowerCalculation calc = new PowerCalculation();

        int intResult = calc.Power(2, 3);
        double doubleResult = calc.Power(5.5, 2);

        Console.WriteLine("2^3 = " + intResult);
        Console.WriteLine("5.5^2 = " + doubleResult);
    }
}
