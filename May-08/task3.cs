using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Cryptography;

class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { set; get; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Laptop", Price = 10000 },
            new Product { ID = 2, Name = "Mouse", Price = 250 },
            new Product { ID = 3, Name = "Keyboard", Price = 300 },
            new Product { ID = 4, Name = "Monitor", Price = 2000 },
            new Product { ID = 5, Name = "Printer", Price = 3000 },
        };
        products.Sort((p1, p2)  =>  p2.Price.CompareTo(p1.Price));

        Console.WriteLine("Products sorted by price descending:");
        foreach ( var product in products)
        {
            Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: ${product.Price}");
        }

        Product highestPriceProduct = products[0];
        Console.WriteLine("Product with the Highest Price:");
        Console.WriteLine($"ID: {highestPriceProduct.ID}, Name: {highestPriceProduct.Name}, Price: ${highestPriceProduct.Price}");
    }
}