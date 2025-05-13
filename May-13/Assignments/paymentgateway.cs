using System;

abstract class PaymentGateway
{
    public abstract void ProcessPayment(double amount);
    public void ShowGatewayName()
    {
        Console.WriteLine("Processing payment through gateway");
    }
}

//StripeGateway implements abstract method 
class StripeGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through Stripe: {amount}");
    }
}

//PayPalGateway implements abstract method
class PayPalGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through PayPal: {amount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PaymentGateway Stripe = new StripeGateway();
        Stripe.ShowGatewayName();
        Stripe.ProcessPayment(10000);

        PaymentGateway paypal = new PayPalGateway();
        paypal.ShowGatewayName();
        paypal.ProcessPayment(30000);
    }
}

