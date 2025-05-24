using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Queuing tasks to ThreadPool..\n");

        for (int i = 1; i <= 5; i++)
        {
          int item = i;
          ThreadPool.QueueUserWorkItem(ProcessItem, item);
        }
        Thread.Sleep(1000);
        Console.WriteLine("\nAll ThreadPool tasks queued.");
    }
    static void ProcessItem(object item)
    {
        int id = (int)item;
        Console.WriteLine($"Processing item {id} on thread...");
        Thread.Sleep(500);
        Console.WriteLine($"Finished item {id}");
    }
}