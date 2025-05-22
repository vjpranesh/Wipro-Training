using System;
using System.Reflection.Metadata.Ecma335;

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Fee { get; set; }
    public Course (int id, string title, double fee)
    {
        Id = id; 
        Title = title;
        Fee = fee;
    }
}

//Interface
interface IEnrollable
{
    void Enroll(Course course);
}

class User : IEnrollable
{
    public string name { get; set; }
    private List<(Course,double)> enrolledCourses = new List<(Course, double )> ();
    public User(string name)
    {
        name = name;
    }

    public void Enroll(Course course)
    {
        enrolledCourses.Add((course, course.Fee));
        Console.WriteLine($"Enrolled in {course.Title} at Full fee: ${course.Fee}");
    }

    public void Enroll(Course course, string couponCode)
    {
        double discount = 0;
        if (couponCode == "DISCOUNT30")
            discount = 0.30;
        if (couponCode == "DISCOUNT40")
            discount = 0.40;

        double finalFee = course.Fee * (1 - discount);
        enrolledCourses.Add((course, finalFee));
        Console.WriteLine($"Enrolled in {course.Title} with coupon '{couponCode}' : ${finalFee}");

    }

    public void PrintEnrollments()
    {
        Console.WriteLine($"\n{name} Enrolled Courses:");
        double total = 0;
        foreach (var (course, paidFee) in enrolledCourses)
        {
            Console.WriteLine($"{course.Title}: ${paidFee}");
            total += paidFee;
        }
        Console.WriteLine($"Total Amount Paid: ${total}");
    }
}

class Program
{
    static void Main()
    {
        Course c1 = new Course(1, "C#", 500);
        Course c2 = new Course(2, ".NET", 1000);
        Course c3 = new Course(3, "SQL", 2000);

        //create user
        User user = new User("Ram");

        user.Enroll(c1);
        user.Enroll(c2, "DISCOUNT30");
        user.Enroll(c3, "DISCOUNT40");

        user.PrintEnrollments();
    }
}