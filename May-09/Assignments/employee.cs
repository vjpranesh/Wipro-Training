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