using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        // add 6 employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Bob", Department = "IT"},
            new Employee { Name = "Babu", Department = "HR"},
            new Employee { Name = "Virat", Department = "Marketing"},
            new Employee { Name = "Priya", Department = "Finance"},
            new Employee { Name = "Anu", Department = "IT"},
            new Employee { Name = "Ram", Department = "HR"}
        };

        //LINQ to group them
        var groupedEmployees = employees
            .GroupBy(e => e.Department);

        Console.WriteLine("Employees Grouped by Department:");
        foreach ( var group in groupedEmployees)
        {
            Console.WriteLine($"\nDepartment: {group.Key}");
            foreach ( var employee in group)
            {
                Console.WriteLine($" {employee.Name}");
            }
        }
    }
}
