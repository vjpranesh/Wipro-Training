using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> studentNames = new List<string>();
        studentNames.Add("Ram");
        studentNames.Add("Vishal");
        studentNames.Add("Venky");
        studentNames.Add("Surya");
        studentNames.Add("Dhoni");

        if (studentNames.Contains("Surya"))
            Console.WriteLine("Name  Surya exists.");
        else
            Console.WriteLine("Not exists.");

        if (studentNames.Count > 1)
        {
            Console.WriteLine($"\nRemoving second name: {studentNames[1]}");
            studentNames.RemoveAt(1);
        }

        Console.WriteLine("Final list:");
        

        foreach (var item in studentNames)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}