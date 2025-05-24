using System;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting tasks...\n");

        Task<string> t1 = TaskWithDelay("Task A", 2000);
        Task<string> t2 = TaskWithDelay("Task B", 3000);
        Task<string> t3 = TaskWithDelay("Task C", 1000);

        Task<string> firstFinished = await Task.WhenAny(t1, t2, t3);

        Console.WriteLine($"\nFirst task completed: {firstFinished.Result}");
    }
    static async Task<string> TaskWithDelay(string name, int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed after {delay}ms");
        return name;
    }
}