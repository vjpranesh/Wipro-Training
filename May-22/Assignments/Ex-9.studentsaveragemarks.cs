using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        // add 5 students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Bob", Marks = 98},
            new Student { Name = "Alice", Marks = 82},
            new Student { Name = "Venky", Marks = 93},
            new Student { Name = "Bheem", Marks = 77},
            new Student { Name = "Sneha", Marks = 80}
        };

        //average mark
        double average = students.Average(s => s.Marks);
        Console.WriteLine($"Average Marks: {average}");

        //count students scored above average
        int countAboveAverage = students.Count(s => s.Marks > average);
        Console.WriteLine($" Students scored above average: {countAboveAverage}");
    }
}