using System;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Sequential execution:\n");
        Stopwatch swsequential = Stopwatch.StartNew();

        await SimulateWorkAsync("Task 1", 1500);
        await SimulateWorkAsync("Task 2", 1500);
        await SimulateWorkAsync("Task 3", 1500);

        swsequential.Stop();
        Console.WriteLine($"\nTotal time (sequential): {swsequential.ElapsedMilliseconds}ms");

        Console.WriteLine("Parallel execution with Task.WhenAll():\n");
        Stopwatch swParallel = Stopwatch.StartNew();

        Task t1 = SimulateWorkAsync("Task 1", 1500);
        Task t2 = SimulateWorkAsync("Task 2", 1500);
        Task t3 = SimulateWorkAsync("Task3", 1500);

        await Task.WhenAll(t1, t2, t3);

        swParallel.Stop();
        Console.WriteLine($"\nTotal time (parallel): {swParallel.ElapsedMilliseconds}ms");
    }

    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started..");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed after {delay} ms");
    }
}