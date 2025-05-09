using System;
using System.Diagnostics;

class Student
{
    public int RollNumber;
    public String Name;
    public int Marks;

    public void PrintDetails()
    {
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Marks: {Marks}");
    }


}

//class Program
//{
//    static void Main()
//    {
//        Student student1 = new Student();
//        student1.RollNumber = 101;
//        student1.Name = "Amit";
//        student1.Marks = 85;

//        student1.PrintDetails();
//    }
//}

class Program
{
    static void Main()
    {
        Student student1 = new Student { RollNumber = 101, Name = "Neha", Marks = 90 };
        Student student2 = new Student { RollNumber = 102, Name = "Ravi", Marks = 65 };

        student1.PrintDetails();
        student2.PrintDetails();
    }
}
