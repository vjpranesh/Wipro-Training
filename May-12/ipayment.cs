using System;

interface IPayment
{
    void ProcessPayment(decimal amount);
}

class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
      Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}

class Program
{
    static void Main()
    {
        //using interface as reference
        IPayment payment;

        //cc payment
        payment = new CreditCardPayment();
        payment.ProcessPayment(1500.50m);

        //paypal payment
        payment = new PayPalPayment();
        payment.ProcessPayment(2500.75m);
    }
}