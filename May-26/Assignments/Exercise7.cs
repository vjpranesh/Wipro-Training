using System;

abstract class CompressionStrategy
{
    public abstract void Compress(string inputPath, string outputPath);
}

class ZipCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compression '{inputPath}' to ZIP at '{outputPath}'");
    }
}

class RarCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing '{inputPath}' to RAR at '{outputPath}'");
    }
}

class Compressor
{
    CompressionStrategy strategy;
    public Compressor (CompressionStrategy strategy)
    {
        this.strategy = strategy;
    }
    public void SetStrategy(CompressionStrategy newStrategy)
    {
        strategy = newStrategy;
    }

    public void CompressFile(string inputPath, string outputPath)
    {
        strategy.Compress(inputPath, outputPath);
    }
}

class Program
{
    static void Main()
    {
        var zipstrategy = new ZipCompression();
        var rarstrategy = new RarCompression();

        var compressor = new Compressor(zipstrategy);
        compressor.CompressFile("sample.txt", "sample.zip");

        compressor.SetStrategy(rarstrategy);
        compressor.CompressFile("sample.csv", "sample.rar");
    }
}