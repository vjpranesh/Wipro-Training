using System;
using System.Linq;

class Item
{
    public string Name;
    public string Type;
    public int Stock;
    public decimal Price;
}

class Program
{
    static void Main()
    {
        var items = new List<Item>
        {
            new Item {Name = "Laptop", Type = "Electronics", Stock = 20, Price = 1000 },
            new Item {Name = "Mouse", Type = "Electronics", Stock = 5 , Price = 500 },
            new Item {Name = "Keyboard", Type = "Electronics", Stock = 3, Price = 300 },
            new Item {Name = "Pendrive", Type = "Electronics", Stock = 4, Price = 150 },
            new Item {Name = "Banana", Type = "Fruits", Stock = 20, Price = 5 },
            new Item {Name = "Apple", Type = "Fruits", Stock = 15, Price = 10 },
            new Item {Name = "Orange", Type = "Fruits", Stock = 10, Price = 15 },
            new Item {Name = "Watermelon", Type = "Fruits", Stock = 10, Price = 20 },
            new Item {Name = "Mango", Type = "Fruits", Stock = 10, Price = 20 },
            new Item {Name = "Strawberry", Type = "Fruits", Stock = 20, Price = 30 },
            new Item {Name = "Pen", Type = "Stationary", Stock = 10, Price = 10 },
            new Item {Name = "Pencil", Type = "Stationary", Stock = 20, Price = 10 },
            new Item {Name = "Eraser", Type = "Stationary", Stock = 20, Price = 5},
            new Item {Name = "Notebook", Type = "Stationary", Stock = 30, Price = 35},
            new Item {Name = "A4 sheet", Type = "Stationary", Stock = 20, Price = 2 }
        };

        //filter low stcok items
        var lowStock = items.Where(i => i.Stock < 10);

        Console.WriteLine("Low Stock items:");
        foreach (var item in lowStock)
            Console.WriteLine($"{item.Name} ({item.Type}) - Stock:${item.Stock}");

        Console.WriteLine("\nHighest price item");

        //highest price item in each group
        var highestInGroup = items
            .GroupBy(i => i.Type)
            .Select(g => g.OrderByDescending(i => i.Price).First());

        foreach (var item in highestInGroup)
            Console.WriteLine($"{item.Type} - {item.Name} - ${item.Price}");
    }
}