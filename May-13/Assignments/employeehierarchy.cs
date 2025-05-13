using System.Data;
using System;

abstract class Employee
{
    public abstract void CalculateSalary();
    public void ShowBasicInfo()
    {
        Console.WriteLine("Employee details");
    }
}

//FullTimeEmployee class
class FullTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Salary: Basic + Allowance");
    }
}

//PartTimeEmployee class

class PartTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Salary: Hourly rate x Hours worked");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee fullTime = new FullTimeEmployee();
        fullTime.ShowBasicInfo();
        fullTime.CalculateSalary();

        Employee partTime = new PartTimeEmployee();
        partTime.ShowBasicInfo();
        partTime.CalculateSalary();
    }
}