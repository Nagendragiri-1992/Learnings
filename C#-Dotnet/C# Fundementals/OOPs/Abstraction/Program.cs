using System;

abstract class Payment
{
    public abstract void ProcessPayment(decimal amount); // Abstract method
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment(decimal amount)
        => Console.WriteLine($"Paid {amount} via Credit Card.");
}

class UpiPayment : Payment
{
    public override void ProcessPayment(decimal amount)
        => Console.WriteLine($"Paid {amount} via UPI.");
}

class Program
{
    static void Main(string[] args)
    {
        Payment payment1 = new CreditCardPayment();
        payment1.ProcessPayment(500);

        Payment payment2 = new UpiPayment();
        payment2.ProcessPayment(300);
    }
}
