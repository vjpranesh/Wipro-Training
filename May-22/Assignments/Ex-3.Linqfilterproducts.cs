using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1000 },
            new Product { Name = "TV", Price = 700 },
            new Product { Name = "Printer ", Price = 600 },
            new Product { Name = " Pendrive ", Price = 500 },
            new Product { Name = "Keyboard", Price = 400 }
        };

        // LINQ  filter products price > 500
        var filteredProducts = products.Where(p => p.Price > 500).ToList();

        Console.WriteLine("Products with price > 500");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"{product.Name} : ${product.Price}");
        }
    }
}
