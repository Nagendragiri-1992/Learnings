using System;

class BankAccount
{
    private decimal balance;  // Private field for data security

    // Public method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Public method to view balance
    public decimal GetBalance() => balance;
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        decimal ip = Convert.ToDecimal(Console.ReadLine());

        //test
        account.Deposit(ip);         // Valid deposit
        Console.WriteLine($"Balance: {account.GetBalance()}");

        account.Deposit(-500);         // Invalid deposit
        Console.WriteLine($"Balance after invalid deposit: {account.GetBalance()}");
    }
}
