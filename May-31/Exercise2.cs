using System;
using System.Transactions;

class Employee
{
    public int ID { get; set; }
    public String Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
    public Employee(int id , string name, string department , double salary)
    {
        ID = id;
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        //list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Bob", "IT", 40000),
            new Employee(2, "Alice", "HR", 50000),
            new Employee(3, "Ram", "Marketing", 55000),
            new Employee(4, "Sneha", "Finance", 60000),
            new Employee(5, "Priya", "IT", 65000)
        };

        //filter employees by department 
        Console.WriteLine("Employees by Department:");
        var departments = employees.Select(e => e.Department).Distinct();

        foreach (var dept in departments)
        {
            Console.WriteLine($"\nDepartment:{dept}");
            var deptEmployees = employees.Where(e => e.Department == dept);
            foreach (var emp in deptEmployees)
                Console.WriteLine($"{emp.Name} - ${emp.Salary}");
        }

        //sort salary in descending 
        Console.WriteLine("\nEmployees sorted by salary:");
        var sortedEmployees = employees.OrderByDescending(e => e.Salary);
        foreach(var emp in sortedEmployees)
            Console.WriteLine($"{emp.Name} - {emp.Department} - {emp.Salary}");
            

        //average salary per department
        Console.WriteLine("\nAverage Salary per Department:");
        var avgSalaries = employees
            .GroupBy(e => e.Department)
            .Select(g => new
            {
                Department = g.Key,
                AverageSalary = g.Average(e => e.Salary)
            });

        foreach ( var dept in avgSalaries)
            Console.WriteLine($"{dept.Department}:{dept.AverageSalary}");
    }
}