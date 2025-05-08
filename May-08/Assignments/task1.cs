using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> studentNames = new List<string>();
        studentNames.Add("Vijay");
        studentNames.Add("Vishal");
        studentNames.Add("Venky");
        studentNames.Add("Ajith");
        studentNames.Add("Johnny");

        if (studentNames.Contains("Ajith"))
            Console.WriteLine("Name exists.");
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