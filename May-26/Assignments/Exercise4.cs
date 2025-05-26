using System;
using System.Threading;

class Program
{
    static Queue<string> taskQueue = new Queue<string>();
    static readonly object locker = new object();
    static bool done = false;

    static void Worker()
    {
        while (true)
        {
            string task = null;

            lock (locker)
            {
                if (taskQueue.Count > 0)
                {
                    task = taskQueue.Dequeue();
                }
                else if (done)
                {
                    break;  //exit task ends 
                }
            }
            if (task != null)
            {
                Console.WriteLine($"Processing : {task}");
                Thread.Sleep(1000);
            }
            else
            {
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("Worker thread exiting");
    }
    static void Main()
    {
        Thread workerThread = new Thread(Worker);
        workerThread.Start();

        //Enqueue 5 task
        for (int i = 1; i <= 5; i++)
        {
            lock (locker)
            {
                taskQueue.Enqueue($"Task {i} ");
                Console.WriteLine($"Enqueued: Task {i}");
            }
            Thread.Sleep(500);
        }

        lock (locker)
        {
            done = true;

        }
        workerThread.Join();
        Console.WriteLine("Main thread exiting");
    }
}