using System;
using System.Collections.Generic;
using System.IO;

class Transaction
{
    public DateTime Time;
    public string Type;
    public decimal Amount;

    public override string ToString()
    {
        return $"{Time},{Type},{Amount}";
    }

    public static Transaction FromString(string line)
    {
        var parts = line.Split(',');
        return new Transaction
        {
            Time = DateTime.Parse(parts[0]),
            Type = parts[1],
            Amount = decimal.Parse(parts[2])
        };
    }
}

//BankAccount 
class BankAccount
{
    decimal balance = 0;
    List<Transaction> history = new List<Transaction>();
    string file = "transactions.txt";

    public BankAccount()
    {
        LoadHistory();
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Enter a amount");
            return;
        }
        balance += amount;
        SaveTransaction("Deposit", amount);
    }
    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > balance)
        {
            Console.WriteLine("Invalid amount");
            return;
        }
        balance -= amount;
        SaveTransaction("Withdraw", amount);
    }
    void SaveTransaction(string type, decimal amount)
    {
        var t = new Transaction { Time = DateTime.Now, Type = type, Amount = amount };
        history.Add(t);
        File.AppendAllLines(file, new[] { t.ToString() });
    }

    void LoadHistory()
    {
        if (!File.Exists(file))
            return;

        foreach (var line in File.ReadAllLines(file))
        {
            var t = Transaction.FromString(line);
            history.Add(t);
            if (t.Type == "Deposit") balance += t.Amount;
            else if (t.Type == "Withdraw") balance -= t.Amount;
        }
    }

    public void ShowSummary()
    {
        Console.WriteLine($"Balance: {balance:0.00}");
        Console.WriteLine("History:");
        foreach (var t in history)
            Console.WriteLine($"{t.Time} - {t.Type} - {t.Amount:0.00}");
    }
}

class Program
{
    static void Main()
    {
        var account = new BankAccount();
        account.ShowSummary();

        string input;
        do
        {
            Console.WriteLine("\nD = Deposit, W = Withdraw, Q = Quit");
            Console.Write("Your choice:");
            input = Console.ReadLine().ToUpper();

            if (input == "D")
            {
                Console.Write("Amount to deposit:");
                decimal amt = decimal.Parse(Console.ReadLine());
                account.Deposit(amt);
            }
            else if (input == "W")
            {
                Console.Write("Amount to withdraw:");
                decimal amt = decimal.Parse(Console.ReadLine());
                account.Withdraw(amt);
            }
        } while (input != "Q");
        Console.WriteLine("\nFinal Summary:");
        account.ShowSummary();
    }
}