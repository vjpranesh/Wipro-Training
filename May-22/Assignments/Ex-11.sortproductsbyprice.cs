using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        //add products to list
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = " Laptop", Price = 1000},
            new Product { Id = 2, Name = " Mobile", Price = 700},
            new Product { Id = 3, Name = " Headphone", Price = 500},
            new Product { Id = 4, Name = " TV", Price = 300},
            new Product { Id = 5, Name = " Printer", Price = 600},
            new Product { Id = 6, Name = " Mouse", Price = 200},
        };

        //sort the products
        var sortedProducts = products.OrderByDescending( p => p.Price).ToList();

        Console.WriteLine("Products sorted by price:");
        foreach ( var product in sortedProducts )
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: ${product.Price}");
        }
    }
}
