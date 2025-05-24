using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(() =>
        {
            Console.WriteLine("Printing task started.");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Printing: {i}");
                Thread.Sleep(200);
            }
            Console.WriteLine("Printing task finished.");
        });

        Thread t2 = new Thread(() =>
        {
            Console.WriteLine("Computing task started.");
            long sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Computing task finished. ");
        });

        Thread t3 = new Thread(() =>
        {
            Console.WriteLine("Waiting task started.");
            Thread.Sleep(1500);
            Console.WriteLine("Waiting task finished.");
        });

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("All tasks done.");
    }
}