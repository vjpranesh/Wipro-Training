using System;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {

        Task t1 = RiskyTaskAsync("Task 1");
        Task t2 = RiskyTaskAsync("Task 2");
        Task t3 = RiskyTaskAsync("Task 3");

        try
        {
            await Task.WhenAll(t1, t2, t3);
            Console.WriteLine("All tasks completed.");
        }
        catch
        {
            Console.WriteLine("One task failed");

            if (t1.IsFaulted)
                Console.WriteLine("Task 1 failed");
            if (t2.IsFaulted)
                Console.WriteLine("Task 2 failed");
            if (t3.IsFaulted)
                Console.WriteLine("Task 3 failed");
        }

    }
    static async Task RiskyTaskAsync(string name)
    {
        await Task.Delay(500);

        // throws an exception
        if (name == "Task 2")
            throw new Exception("Something wrong in " + name);

        Console.WriteLine(name + " completed");
    }
}