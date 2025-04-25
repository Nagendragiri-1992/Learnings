using System;

class Printer
{
    public virtual void Print() => Console.WriteLine("Printing a document...");
}

class LaserPrinter : Printer
{
    public override void Print() => Console.WriteLine("Printing with Laser Printer...");
}

class InkjetPrinter : Printer
{
    public override void Print() => Console.WriteLine("Inkjet Printer");
}

class Program
{
    static void Main(string[] args)
    {
        Printer printer1 = new Printer();
        Printer printer2 = new LaserPrinter();
        Printer printer3 = new InkjetPrinter();
        printer1.Print();
        printer2.Print();
        printer3.Print();
    }
}
