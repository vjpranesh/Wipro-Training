using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var stopwatch = Stopwatch.StartNew();

        Console.WriteLine("Fetching weather for 3 cities\n");

        
        Task<string> city1 = GetWeatherAsync("Chennai", 1000);
        Task<string> city2 = GetWeatherAsync("Bangalore", 2000);
        Task<string> city3 = GetWeatherAsync("Pune", 3000);

        // Wait for all tasks to finish
        var results = await Task.WhenAll(city1, city2, city3);

        stopwatch.Stop();

        
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine($"\nTotal time taken: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task<string> GetWeatherAsync(string city, int delay)
    {
        //delay
        await Task.Delay(delay); 
        return $"Weather in {city}: {new Random().Next(15, 35)}°C (fetched in {delay}ms)";
    }
}
