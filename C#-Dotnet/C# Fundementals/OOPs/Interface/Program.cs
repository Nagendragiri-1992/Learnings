using System;

interface IShape
{
    void Draw();  // Method declaration
}

interface IColor
{
    void Paint(string color);  // Another interface
}

class Circle : IShape, IColor
{
    public void Draw() => Console.WriteLine("Drawing a Circle.");
    public void Paint(string color) => Console.WriteLine($"Circle painted with {color} color.");
}

class Program
{
    static void Main(string[] args)
    {
        //test
        Circle circle = new Circle();
        circle.Draw();
        circle.Paint("Blue");
    }
}
