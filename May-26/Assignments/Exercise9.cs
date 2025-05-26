using System;
using System.ComponentModel;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var tasks = new Task[]
        {
            Task.Run(() => DoWork("Task1", 1000)),
            Task.Run(() => DoWork("Task2", 2000, throwError: true)),
            Task.Run(() => DoWork("Task3", 3000)),
            Task.Run(() => DoWork("Task4", 4000, throwError: true)),
            Task.Run(() => DoWork("Task5", 5000))
        };
        try
        {
            await Task.WhenAll(tasks);
        }
        catch
        {
            foreach (var t in tasks)
            {
                if (t.Exception != null)
                {
                    foreach (var ex in t.Exception.InnerExceptions)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
        }
        Console.WriteLine("Summary: All tasks attempted");
    }
    static async Task DoWork(string name, int delay, bool throwError = false)
    {
        await Task.Delay(delay);
        if (throwError)
        {
            throw new Exception($"{name} failed");
        }
        Console.WriteLine($"{name} completed successfully");
    }
}
