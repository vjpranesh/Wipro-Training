using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool pause = false;
        bool stop = false;
        int counter = 1;

        Thread thread = new Thread(() =>
        {
            while (counter <= 100)
            {
                if (stop) break;
                if (!pause)
                {
                    Console.WriteLine(counter++);
                    Thread.Sleep(100);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        });
        thread.Start();

        Thread.Sleep(1000);
        pause = true;
        Console.WriteLine("Paused.Thread state:" + thread.ThreadState);

        Thread.Sleep(1000);
        pause = false;
        Console.WriteLine("Resumed.Thread state:" + thread.ThreadState);

        Thread.Sleep(2000);
        stop = true;
        Console.WriteLine("Stopping.Thread state:" + thread.ThreadState);

        thread.Join();
        Console.WriteLine("Thread finished");
    }
}