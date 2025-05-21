//Recursion - Tower Of Hanoi


using System;

class Program
{
    static void TowerOfHanoi(int n, char from, char to, char aux)
    {
        if ( n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }
        TowerOfHanoi(n - 1, from, aux, to);

        Console.WriteLine($"Move disk {n} form {from} to {to}");

        TowerOfHanoi(n - 1, aux, to, from);
    }
    static void Main()
    {
        Console.WriteLine("Enter the number of disks:");
        int n = int.Parse(Console.ReadLine());

        TowerOfHanoi(n, 'A', 'B', 'C');
    }
}