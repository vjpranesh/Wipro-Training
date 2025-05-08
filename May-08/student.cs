using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Versioning;

class Student
{
    public int ID {get; set;}
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Alice"},
            new Student { ID = 2, Name = "Bob"}
        };

        students.Add (new Student { ID = 3, Name = "Charlie" });

        foreach ( var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
        }
    }
}