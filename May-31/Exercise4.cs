using System;

class Program
{
    static int totalLines = 0;
    static object lockObj = new object();
    static void ReadFile(string filePath)
    {
        try
        {
            int lineCount = 0;
            foreach (var line in File.ReadLines(filePath))
            {
                lineCount++;
            }
            Console.WriteLine($"{filePath} - Lines: {lineCount}");

            lock (lockObj)
            {
                totalLines += lineCount;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading {filePath}: {ex.Message}");
        }
    }
    static void Main()
    {
        string[] files = { "file1.txt", "file2.txt", "file3.txt" };

        Thread[] threads = new Thread[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            string path = files[i];
            threads[i] = new Thread(() => ReadFile(path));
            threads[i].Start();
        }

        foreach (var t in threads)
        {
            t.Join();
        }

        Console.WriteLine($"\nTotal lines across all files : {totalLines}");
    }
}