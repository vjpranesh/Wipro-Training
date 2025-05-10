using System;

class Payment
{
    public decimal Amount;
    public string Currency;

    public virtual void ProcessPayment()
    {
        Console.WriteLine($"Processing payment of {Amount} {Currency}");
    }

    // Overloaded method to process payment with amount and currency
    public void ProcessPayment(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
        Console.WriteLine($"Processing payment of {Amount} {Currency}");
    }
}

class CreditCardPayment : Payment
{
    public string CardNumber;

    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing Credit Card payment of {Amount} {Currency}");
    }
}

class PayPalPayment : Payment
{
    public string EmailAddress;

    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing PayPal payment of {Amount} {Currency}");
    }
}

class Program
{
    static void Main()
    {
        CreditCardPayment ccPayment = new CreditCardPayment();
        ccPayment.CardNumber = "1234-5678-9101";
        ccPayment.ProcessPayment(20000, "USD");
        ccPayment.ProcessPayment();

        Console.WriteLine();

        PayPalPayment ppPayment = new PayPalPayment();
        ppPayment.EmailAddress = "user@example.com";
        ppPayment.ProcessPayment(20000, "USD");
        ppPayment.ProcessPayment();

        Console.WriteLine();
    }
}
