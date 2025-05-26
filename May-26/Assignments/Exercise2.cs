using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    string name;
    int marks;
    string grade;

    public string Name { get => name; set => name = value; }
    public int Marks { get => marks; set => marks = value; }
    public string Grade { get => grade; set => grade = value; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "Alice", Marks = 96, Grade = "A" },
            new Student { Name = "Bob", Marks = 87, Grade = "B" },
            new Student { Name = "Ram", Marks = 92, Grade = "A" },
            new Student { Name = "Sneha", Marks = 85, Grade= "B" },
            new Student { Name = "Charles", Marks = 77, Grade = "C" },
            new Student { Name = "Neha", Marks = 90, Grade = "A" },
            new Student { Name = "Prem", Marks = 70, Grade = "C" },
            new Student { Name = "Stephen", Marks = 82, Grade = "B" },
            new Student { Name = "Julie", Marks = 65, Grade = "D" },
            new Student { Name = "Georage", Marks = 80, Grade = "B" }
        };

        var sorted = students.OrderByDescending(s => s.Marks);

        Console.WriteLine("Sorted by Marks (Descending):");
        foreach (var s in sorted)
            Console.WriteLine($"{s.Name} - {s.Marks} - Grade {s.Grade}");

        Console.WriteLine("\nGrouped by Grade:");
        var grouped = students.GroupBy(s => s.Grade);
        foreach (var group in grouped)
        {
            Console.WriteLine($"Grade {group.Key}");
            foreach (var s in group)
                Console.WriteLine($" {s.Name} - {s.Marks}");
        }

        Console.WriteLine("\nTop 3 Students:");
        foreach (var s in sorted.Take(3))
            Console.WriteLine($"{s.Name} - {s.Marks} - Grade {s.Grade}");
    }
}


