using System;
using System.Data;

interface IAttendance
{
    void MarkAttendance();
}

//abstract class
abstract class Staff : IAttendance
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public Staff (int id, string name, string department)
    {
        Id = id;   
        Name = name;
        Department = department;
    }
    public abstract double CalculateSalary();
    public abstract void MarkAttendance();
}



//permanentstaff class
class PermanentStaff : Staff
{
    public double BasicSalary { get; set; }
    public double Allowance {  get; set; }
    public PermanentStaff(int id, string name, string department,double basicSalary, double  allowance) : base (id, name , department)
    {
        BasicSalary = basicSalary;
        Allowance = allowance;
    }

    public override double CalculateSalary()
    {
        return BasicSalary + Allowance;
    }

    public override void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Permanent)  - Attendance marked.");
    }
}


//contract class staff
class ContractStaff : Staff
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public ContractStaff(int id, string name, string department, double hourlyRate, int hoursWorked) : base(id, name, department)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Contract) - Attendance marked.");
    }
}



class Program
{
    static void Main()
    {
        List<Staff> employees = new List<Staff>
        {
            new PermanentStaff(1, "Bob", "IT", 4000, 200 ),
            new PermanentStaff(2, "Reddy", "HR", 3000, 100),
            new ContractStaff(3, "Vino" , "Marketing", 30, 50),
            new ContractStaff(4, "Abi", "Finance", 40, 60)
        };
        foreach (var emp in  employees)
        {
            emp.MarkAttendance();
            Console.WriteLine($"{emp.Name} - Salary: ${emp.CalculateSalary()}");
        }
    }
}