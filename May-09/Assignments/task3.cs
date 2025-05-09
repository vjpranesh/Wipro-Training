// method overriding 

using System;
 class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a Shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

class Program
{
    static void Main()
    {
        Shape shapeRef = new Circle();

        shapeRef.Draw();
    }
}