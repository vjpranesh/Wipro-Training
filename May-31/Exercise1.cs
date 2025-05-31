using System;
using System.Collections.Generic;

interface IRentable
{
    public void Rent(int days);
}

class Vehicle
{
    public string Model { get; set; }
    public double RentPerDay { get; set; }
    public Vehicle(string model, double rentPerDay)
    {
        Model = model;
        RentPerDay = rentPerDay;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model},Rent Per Day: ${RentPerDay}");
    }
}

class Car: Vehicle, IRentable
{
    public Car(string model, double rentPerDay) : base(model, rentPerDay) { }
    public void Rent(int days )
    {
        double total = days * RentPerDay;
        Console.WriteLine($"Car rented for {days},Total cost:${total}");
    }
   
}

class Bike: Vehicle,IRentable
{
    public Bike(string model, double rentPerDay) : base(model, rentPerDay) { }
    public void Rent(int days)
    {
        double total = days*RentPerDay;
        Console.WriteLine($"Bike rented for {days} days.Total cost:${total}");
    }
}

class Truck : Vehicle, IRentable
{
    public Truck(string model, double rentPerDay) : base(model, rentPerDay) { }
    public void Rent(int days)
    {
        double total = days * RentPerDay;
        Console.WriteLine($"Truck rented fort {days}.Total cost:${total}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IRentable> vehicles = new List<IRentable>
        {
            new Car("Tata Altroz", 200),
            new Bike("Bajaj Pulsar", 100),
            new Truck("Leyland Truck", 400)
        };
        Console.WriteLine("Vehicle Rental System:\n");

        int days = 5;
        foreach ( var v in vehicles)
        {
            if ( v is Vehicle vehicle)
            {
                vehicle.DisplayInfo();
            }
            v.Rent(days);
            Console.WriteLine();
        }
    }
}