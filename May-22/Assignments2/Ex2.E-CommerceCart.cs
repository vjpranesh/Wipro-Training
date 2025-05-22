using System;


class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Product (int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    public double GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}

class ShoppingCart
{
    private List<CartItem> items = new List<CartItem>();
    public void AddItem(Product product, int quantity)
    {
        var existingItem = items.FirstOrDefault(i => i. Product.Id == product.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            items.Add(new CartItem(product, quantity));
        }
    }
    public void RemoveItem( int productId)
    {
        items.RemoveAll( i => i.Product.Id == productId );
    }
    public double GetCartTotal()
    {
        return items.Sum(i => i.GetTotalPrice());
    }
    public void PrintCart()
    {
        Console.WriteLine("Cart Items:");
        foreach ( var item in items)
        {
            Console.WriteLine($"{item.Product.Name} x {item.Quantity} = ${item.GetTotalPrice()}");
        }
        Console.WriteLine($"Total : ${GetCartTotal()}");
    }
}

class Program
{
    static void Main()
    {
        //create products
        Product p1 = new Product(1, "Mobile", 10000);
        Product p2 = new Product(2, "Monitor",8000);
        Product p3 = new Product(3, "Laptop", 30000);

        //create shoppingcart
        ShoppingCart cart = new ShoppingCart();

        //add products  with quantity to cart 
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 2);
        cart.AddItem(p3, 1);

        cart.PrintCart();

    }
}
