using System;

class Calculator
{
    public int Add(int a, int b) => a + b;       // Adds integers
    public double Add(double a, double b) => a + b; // Adds doubles
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(5, 10));       // Calls int version
        Console.WriteLine(calc.Add(3.5, 2.5));    // Calls double version
    }
}
