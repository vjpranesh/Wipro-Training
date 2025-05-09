using System;

class Employee
{
    public int EmployeeID;
    public string Name;
    public string Department;
    public double Salary;

    public void PrintDetails()
    {
        Console.WriteLine("Employee ID: " + EmployeeID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department:" + Department);
        Console.WriteLine("Salary:" + Salary);
    }
    public void UpdateSalary(double newSalary)
    {
        Salary = newSalary;
    }
    public double AnnualSalary()
    {
        return Salary * 12;
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee { EmployeeID = 1, Name = "Ram", Department = "IT", Salary = 70000 };
        //emp1.EmployeeID = 1;
        //emp1.Name = "Ram";
        //emp1.Department = "IT";
        //emp1.Salary = 70000;

        emp1.PrintDetails();
        Console.WriteLine("\nUpdate Salary");
        emp1.UpdateSalary(80000);

        emp1.PrintDetails();

        Console.WriteLine("\nAnnual Salary: $" + emp1.AnnualSalary());
    }
}




//adding class 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        public void PrintDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department:" + Department);
            Console.WriteLine("Salary:" + Salary);
        }
        public void UpdateSalary(double newSalary)
        {
            Salary = newSalary;
        }
        public double AnnualSalary()
        {
            return Salary * 12;
        }

    }
}

