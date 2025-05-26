using System;


//Interface 
interface IPaymentProcessor
{
    void ProcessPayment();
}

//abstract class
abstract class PaymentGateway
{
    public string GatewayName { get; set; }
    public decimal Amount { get; set; }

    public PaymentGateway (decimal amount)
    {
        Amount = amount;
    }
    public abstract bool Validate();

}

//Razorpay
class Razorpay : PaymentGateway, IPaymentProcessor
{
    public Razorpay(decimal amount) : base(amount)
    {
        GatewayName = "Razorpay";
    }
    public override bool Validate()
    {
        Console.WriteLine($"{GatewayName}: Validating Razorpay account");
        return true;
    }
    public void ProcessPayment()
    {
        if (Validate())
        {
            Console.WriteLine($"{GatewayName}: Processing payment of ${Amount}");
        }
    }
}

//PayPal
class PayPal : PaymentGateway, IPaymentProcessor
{
    public PayPal(decimal amount ) : base(amount) 
    {
        GatewayName = "PayPal";
    }
    public override bool Validate()
    {
        Console.WriteLine($"{GatewayName}: Validating PayPal account");
        return true;
    }
    public void ProcessPayment()
    {
        if (Validate())
        {
            Console.WriteLine($"{GatewayName}: Processing payment of ${Amount}");
        }
    }
}

//Stripe
class Stripe : PaymentGateway, IPaymentProcessor
{
    public Stripe(decimal amount) : base(amount) 
    {
        GatewayName = "Stripe";
    }
    public override bool Validate()
    {
        Console.WriteLine($"{GatewayName}: Validating Stripe account");
        return true;
    }
    public void ProcessPayment()
    {
        if (Validate())
        {
            Console.WriteLine($"{GatewayName}: Processsing payment of ${Amount}");
        }
    }
}

class Program
{
    public static void Main()
    {
        List<IPaymentProcessor> payments = new List<IPaymentProcessor>
        {
            new Razorpay(1000),
            new PayPal(2000),
            new Stripe(3000)
        };
        foreach (var payment in payments)
        {
            payment.ProcessPayment();
            Console.WriteLine();
        }
    }
}



