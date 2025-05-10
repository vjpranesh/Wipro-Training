using System;

class AreaCalculation
{
    public double Area(double length, double breadth)
    {
        return length * breadth;
    }

    //area of circle 
    public double Area(double radius)
    {
        return 3.14 * radius * radius;
    }

    //area of triangle 
    public double Area(double triangleBase, double height, bool isTriangle)
    {
        return 0.5 * triangleBase * height;
    }
}

class Program
{
    static void Main()
    {
        AreaCalculation calc = new AreaCalculation();

        double rectangleArea = calc.Area(6.0, 7.0);
        double circleArea = calc.Area(8.0);
        double triangleArea = calc.Area(5.0, 2.5, true);

        Console.WriteLine("Area of Rectangle: " + rectangleArea);
        Console.WriteLine("Area of Circle: " + circleArea);
        Console.WriteLine("Area of Triangle:" + triangleArea);
    }
}

