using System;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        CancellationTokenSource cts = new CancellationTokenSource();  

        //start task
        Task task = DoWorkAsync(cts.Token);


        //cancel task after 2seconds
        await Task.Delay(2000);
        cts.Cancel();

        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Task Cancelled.");
        }
    }

    static async Task DoWorkAsync(CancellationToken token)
    {
        Console.WriteLine("Work started.");

        for (int i = 1; i <= 5; i++)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"Working..step{i}");
            await Task.Delay(500);
        }
        Console.WriteLine("Work completed.");
    }
}