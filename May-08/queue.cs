using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Amit");
        queue.Enqueue("Neha");
        queue.Enqueue("Ravu");
        queue.Enqueue("Priya");

        Console.WriteLine("Queue Elements:");
        foreach ( var name in queue)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\nEnqueued: " + queue.Dequeue());

        Console.WriteLine("Next in line: " + queue.Peek());
    }
}