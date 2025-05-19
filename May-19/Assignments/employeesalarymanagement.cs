using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmployeeID;
    public string Name;
    public decimal Salary;

    public Employee(int id, string name, decimal salary)
    {
        EmployeeID = id;
        Name = name;
        Salary = salary;
    }
}

class Program
{
    static  void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(1,"Ram", 50000),
            new Employee(2, "Ajay", 60000),
            new Employee(3, "Vetri", 70000),
            new Employee(4, "Sneha", 80000),
            new Employee(5, "Arun", 90000)
        };

        //employee with highest salary
        Employee highestPaid = employees.OrderByDescending(emp => emp.Salary).First();
        Console.WriteLine($"Highest Paid Employee: {highestPaid.Name}, Salary: {highestPaid.Salary}");

        // store empid and name in dict
        Dictionary<int, string> employeeDirectory = new Dictionary<int, string>();
        foreach (var emp in employees)
        {
            employeeDirectory[emp.EmployeeID] = emp.Name; 
        }

        //displaying dict contents
        Console.WriteLine("\nEmployee Directory:");
        foreach ( var pair in employeeDirectory)
        {
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
        }

        //search for emp by id
        Console.Write("\nEnter Employee ID to search:");
        int searchID = Convert.ToInt32(Console.ReadLine());

        if (employeeDirectory.ContainsKey(searchID))
        {
            Console.WriteLine($"Employee Found: {employeeDirectory[searchID]}");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }

    }
}