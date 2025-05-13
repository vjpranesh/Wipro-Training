using System;

interface IOrder
{
    void PlaceOrder();
    void CancelOrder();
}

//interface in DineInOrder
class DineInOrder : IOrder
{
    public void PlaceOrder ()
    {
        Console.WriteLine("Placing dine - in order for item");
    }
    public void CancelOrder()
    {
        Console.WriteLine("Cancelling dine - in order  for item");
    }
}

//interface in TakeAwayOrder
class TakeAwayOrder : IOrder
{
    public void PlaceOrder()
    {
        Console.WriteLine("Placing takeaway order for item ");
    }
    public void CancelOrder()
    {
        Console.WriteLine("Cancelling takeaway order for item");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IOrder dineIn = new DineInOrder();
        dineIn.PlaceOrder();
        dineIn.CancelOrder();

        IOrder takeaway = new TakeAwayOrder();
        takeaway.PlaceOrder();
        takeaway.CancelOrder();
    }
}