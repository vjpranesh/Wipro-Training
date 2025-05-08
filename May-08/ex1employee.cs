using System;
using System.Collections.Generic;

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> Employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Bob"},
            new Employee { ID = 2, Name = "Kumar"},
            new Employee { ID = 3, Name = "Ram"},
            new Employee { ID = 4, Name = "Arun"},
            new Employee { ID = 5, Name = "Alice"}
        };

        
        for (int i = 0; i < Employees.Count; i++)
        {
            if (Employees[i].Name == "Ram")
            {
                Employees.RemoveAt(i);
                Console.WriteLine("Removed employee with name: Ram");
                break;
            }
        }

        bool exists = false;
        for (int i = 0; i < Employees.Count; i++)
        {
            if (Employees[i].Name == "Kumar")
            {
                exists = true;
                break;
            }
        }
        Console.WriteLine(" Kumar exists " + exists);

        Console.WriteLine("Total employees: " + Employees.Count);

        for (int i = 0; i < Employees.Count; i++)
        {
            Console.WriteLine("ID: " + Employees[i].ID + ", Name: " + Employees[i].Name);
        }
    }
}
