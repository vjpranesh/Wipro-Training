using System;

class Program
{
    static int SumOfDigits(int num)
    {
        int num = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;

        static void Main()
        {
            int number = 1234;
            int sum = SumOfDigits(number);
            Console.WriteLine($"Sum of digits:{sum}");
        }

    }
}