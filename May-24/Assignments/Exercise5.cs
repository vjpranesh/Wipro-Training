using System;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static Random rand = new Random();
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching temperaturs...\n");

        Task<int> t1 = GetTemperatureAsync("Chennai");
        Task<int> t2 = GetTemperatureAsync("Bangalore");
        Task<int> t3 = GetTemperatureAsync("Pune");

        int temp1 = await t1;
        int temp2 = await t2;
        int temp3 = await t3;

        Console.WriteLine($"\nTemperature in Chennai: {temp1}c");
        Console.WriteLine($"\nTemperature in Bangalore: {temp2}c");
        Console.WriteLine($"\nTemperature in Pune: {temp3}c");
    }

    static async  Task<int> GetTemperatureAsync(string city)
    {
        await Task.Delay(1000);
        int temp = rand.Next(-10, 30);
        Console.WriteLine($"Fetched temperature for {city}");
        return temp;
    }
}


  