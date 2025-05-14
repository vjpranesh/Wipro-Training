using System;

abstract class FoodOrder
{
    public abstract void PlaceOrder();
    public void OrderInfo()
    {
        Console.WriteLine("Placing food order");
    }
}

class FastFoodOrder : FoodOrder
{
    public override void PlaceOrder()
    {
        Console.WriteLine($"Order placed for [item] at Fast Food Outlet");
    }
}

class FineDiningOrder : FoodOrder
{
    public override void PlaceOrder()
    {
        Console.WriteLine($"Order placed for [item] at Fine Dining Restaurant");
    }
}

class Program
{
    static void Main()
    {
        FoodOrder fastFood = new FastFoodOrder();
        FoodOrder fineDining = new FineDiningOrder();

        fastFood.OrderInfo();
        fastFood.PlaceOrder();

        fineDining.OrderInfo();
        fineDining.PlaceOrder();
    }
}