using System;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting file downloads..\n");

        var stopwatch = Stopwatch.StartNew();

        Task t1 = DownloadFileAsync("File1.pdf", 2000);
        Task t2 = DownloadFileAsync("File2.jpg", 3000);
        Task t3 = DownloadFileAsync("File3.zip", 4000);

        await Task.WhenAll(t1, t2, t3);

        stopwatch.Stop();
        Console.WriteLine($"\nAll files downloaded in {stopwatch.ElapsedMilliseconds}ms");
    }

    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"Starting download; {fileName}");
        await Task.Delay( delay );
        Console.WriteLine($"Finsihed download: {fileName} ");
    }
}