using System;
using System.Diagnostics;

interface IBankAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void CheckBalance();
}

class SavingsAccount : IBankAccount
{
    private double balance = 0;
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount} to Savings Account");
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw {amount} from Savings Account");
        }
        else
        {
            Console.WriteLine("Insufficient funds in Savings Account");
        }
    }
    public void CheckBalance()
    {
        Console.WriteLine($"Savings Account Balance : {balance}");
    }
}

class CurrentAccount : IBankAccount
{
    private double balance = 0;
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount} to Current Account");
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw {amount} from Current Account");
        }
        else
        {
            Console.WriteLine("Insufficient funds in Current Account");
        }
    }
    public void CheckBalance()
    {
        Console.WriteLine($"Current Account Balance:{balance}");
    }
}

class Program
{
    static void Main()
    {
        IBankAccount savings = new SavingsAccount();
        IBankAccount current = new CurrentAccount();

        savings.Deposit(2000);
        savings.Withdraw(1000);
        savings.CheckBalance();

        Console.WriteLine();

        current.Deposit(3000);
        current.Withdraw(500);
        current.CheckBalance();
    }
}
