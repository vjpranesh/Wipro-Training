using System;
using System.Collections.Generic;

namespace Linq_Practice
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employeeArray = {
            new Employee() {EmployeeID = 1, EmployeeName = "John", Age = 18 },
            new Employee() {EmployeeID = 2, EmployeeName = "Steve", Age = 21 },
            new Employee() {EmployeeID = 3, EmployeeName = "Bill", Age = 25 },
            new Employee() {EmployeeID = 4, EmployeeName = "Ram", Age = 20 },
            new Employee() {EmployeeID = 5, EmployeeName = "Ron", Age = 31 },
            new Employee() {EmployeeID = 6, EmployeeName = "Chris", Age = 17 },
            new Employee() {EmployeeID = 7, EmployeeName = "Rob", Age = 19 },
          };

            //Employee[] Employees = new Employee[10];

            //int i = 0;

            //foreach (employee employee in employeeArray)
            //{
            //    if (employee.Age > 12 && employee.Age < 20)
            //    {
            //        employees[i] = employee;
            //        System.Console.WriteLine(employee.employeename);
            //        i++;
            //    }
            //}


            //use linq to find tennager employees
            Employee[] teenAgerEmployees = employeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            

            //use LINQ to find first employee whose name is Bill
            Employee bill = employeeArray.Where(s => s.EmployeeName == "Bill").FirstOrDefault();
            

            //use LINQ to find employee whose employeeID is 5
            Employee Employee5 = employeeArray.Where(s => s.EmployeeID == 5).FirstOrDefault();
            
        }
    }
}
