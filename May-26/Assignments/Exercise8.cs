using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static async Task Main()
    {
        var images = new List<string>();
        for (int i = 1; i <= 20; i++)
            images.Add($"Image {i}.jpg");

        int total = images.Count;
        int processed = 0;

        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = 5
        };

        await Parallel.ForEachAsync(images, options, async (image, token) =>
        {
            await Task.Delay(200);
            int done = Interlocked.Increment(ref processed);
            Console.WriteLine($"{image} processed - {done * 100 / total}% done");
        });

        Console.WriteLine("All images processed");

    }
}