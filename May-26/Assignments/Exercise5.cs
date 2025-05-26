using System;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    static async Task<string> Server1(CancellationToken token)
    {
        int delay = new Random().Next(1000, 2000);
        await Task.Delay(delay, token);
        return $"Server1 responded in {delay} ms";
    }

    static async Task<string> Server2(CancellationToken token)
    {
        int delay = new Random().Next(1000, 2000);
        await Task.Delay(delay, token);
        return $"Server2 responded in {delay}ms";
    }

    static async Task<string> Server3(CancellationToken token)
    {
        int delay = new Random().Next(1000, 2000);
        await Task.Delay(delay, token);
        return($"Server3 responded in {delay}ms");
    }

    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        //start three tasks
        var tasks = new[]
        {
            Server1(token),
            Server2(token),
            Server3(token)
        };

        //wait for first task to complete
        var firstFinished = await Task.WhenAny(tasks);

        // cancel other tasks
        cts.Cancel();

        try
        {
            Console.WriteLine(await firstFinished);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("First task cancelled");
        }
        Console.WriteLine("Cancelled remaining tasks");
    }
}
  