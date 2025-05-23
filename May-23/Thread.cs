using System;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(500); //pause for 0.5 seconds
        }
    }
    static void Main()
    {
        Thread myThread = new Thread(PrintNumbers); //Create a thread
        myThread.Start();                           //Start a thread

        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Main: {i}");
            Thread.Sleep(500);
        }
    }
}