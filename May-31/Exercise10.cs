using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public List<int> Marks { get; set; }

    public double Average => Marks.Average();
    public int Highest => Marks.Max();
    public int Lowest => Marks.Min();
}

class Program
{
    static void Main()
    {
        
        Dictionary<string, Student> students = new Dictionary<string, Student>();

        
        students["Alice"] = new Student { Name = "Alice", Marks = new List<int> { 85, 90, 78, 88, 91 } };
        students["Bob"] = new Student { Name = "Bob", Marks = new List<int> { 92, 88, 95, 68, 70 } };
        students["Charlie"] = new Student { Name = "Ram", Marks = new List<int> { 70, 68, 75, 65, 89 } };
        students["David"] = new Student { Name = "Priya", Marks = new List<int> { 88, 85, 90, 50, 82 } };

        Console.WriteLine("Student Grades:\n");

        //each student marks
        foreach (var student in students.Values)
        {
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"  Marks: {string.Join(", ", student.Marks)}");
            Console.WriteLine($"  Average: {student.Average}");
            Console.WriteLine($"  Highest: {student.Highest}");
            Console.WriteLine($"  Lowest: {student.Lowest}\n");
        }

        //top 3
        var top3 = students.Values
                           .OrderByDescending(s => s.Average)
                           .Take(3);

        Console.WriteLine("Top 3 Scorers:");
        foreach (var s in top3)
        {
            Console.WriteLine($"{s.Name} - Average: {s.Average}");
        }
    }
}
