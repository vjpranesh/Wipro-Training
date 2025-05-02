using System;

class Program
{
    static int CountZeros(int num)
    {
        if (num == 0)
            return 0;

        int lastDigit = num % 10;
        if (lastDigit == 0)
            return 1 + CountZeros(num / 10);
        else
            return CountZeros(num / 10);
    }
    static void Main()
    {
        int number = 2004350510;
        int zeroCount = CountZeros(number);
        Console.WriteLine("Number of zeros: " + zeroCount);
    }
}
