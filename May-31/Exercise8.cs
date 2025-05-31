using System;
using System.Collections.Generic;

//Interface
interface IPrintable
{
    void Print();
}

//Product class
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double Total => Price * Quantity;
}

// Abstract Invoice class
abstract class Invoice : IPrintable
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product) => Products.Add(product);

    public abstract double CalculateTotal();

    public virtual void Print()
    {
        Console.WriteLine("\n Invoice");
        foreach (var product in Products)
        {
            Console.WriteLine($"{product.Name} - {product.Quantity} x {product.Price} = {product.Total}");
        }
        Console.WriteLine($"Total Amount: {CalculateTotal()}");
    }
}

// RetailInvoice with 10% tax
class RetailInvoice : Invoice
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var p in Products)
            subtotal += p.Total;

        double tax = subtotal * 0.10; 
        return subtotal + tax;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Invoice Type: Retail (10% tax)");
    }
}

// 10% discount 
class WholesaleInvoice : Invoice
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var p in Products)
            subtotal += p.Total;

        double discount = subtotal * 0.10;
        return subtotal - discount;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Invoice Type: Wholesale (10% discount)");
    }
}

class Program
{
    static void Main()
    {
        
        // Retail Invoice
        Invoice retail = new RetailInvoice();
        retail.AddProduct(new Product { Name = "Laptop", Price = 10000, Quantity = 1 });
        retail.AddProduct(new Product { Name = "Mobile", Price = 2500, Quantity = 2 });
        retail.Print();

        // Wholesale Invoice
        Invoice wholesale = new WholesaleInvoice();
        wholesale.AddProduct(new Product { Name = "Monitor", Price = 1500, Quantity = 1 });
        wholesale.AddProduct(new Product { Name = "Keyboard", Price = 500, Quantity = 2 });
        wholesale.Print();
    }
}
