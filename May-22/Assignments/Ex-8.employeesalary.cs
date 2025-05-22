using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main()
    {
        //create dictionary with empID and salary
        Dictionary<int, decimal> salaryTable = new Dictionary<int, decimal>
        {
            { 1, 40000 },
            { 2, 50000 },
            {3, 60000 },
            {4, 70000 },
            {5, 80000 }
        };

        Console.WriteLine("Enter Employee ID :");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int empID))
        {
            if (salaryTable.TryGetValue(empID, out decimal salary))
            {
                Console.WriteLine(($"Employee {empID} ${salary}")); 
            }
            else
            {
                Console.WriteLine("Employee ID not found");
            }
        }
    }
}