using System;


//Interface 
public interface IPaymentProcessor
{
    void ProcessPayment();
}

//abstract class
public abstract class PaymentGateway
{
    public string GatewayName {  get; set; }
    public abstract bool Validate();

}

//Razorpay
public class Razorpay : PaymentGateway,IPaymentProcessor
{
    public Razorpay()
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
            Console.WriteLine($"{GatewayName}: Processing Razorpay payment");
        }
    }
}

//PayPal
public class PayPal : PaymentGateway, IPaymentProcessor
{
    public PayPal()
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
            Console.WriteLine($"{GatewayName}: Processing PayPal payment");
        }
    }
}

//Stripe
public class Stripe : PaymentGateway, IPaymentProcessor
{
    public Stripe()
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
            Console.WriteLine($"{GatewayName}: Processsing Stripe payment");
        }
    }
}

class Program
{
    public static void Main()
    {
        List<IPaymentProcessor> payments = new List<IPaymentProcessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe()
        };
        foreach ( var payment in payments)
        {
            payment.ProcessPayment();
            Console.WriteLine();
        }
    }
}



