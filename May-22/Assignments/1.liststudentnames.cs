using System;

class Program
{
    static void Main()
    {
        //create list students
        List<string> students = new List<string>();

        students.Add("Ram");
        students.Add("Arun");
        students.Add("Bala");
        students.Add("Rohit");
        students.Add("Eswar");

        Console.WriteLine("List of students:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
        //sort the list 
        students.Sort();
        Console.WriteLine("\nSorted list of students:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}