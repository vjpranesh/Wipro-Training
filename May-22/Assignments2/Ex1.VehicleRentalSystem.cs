using System;


//abstract class
abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public double RatePerDay { get; set; }
    public Vehicle(string vehicleNumber, string brand, double ratePerDay)
    {
        VehicleNumber = vehicleNumber;
        Brand = brand;
        RatePerDay = ratePerDay;
    }
    public virtual double CalculateRent (int days)
    {
        return RatePerDay * days;
    }
}

//derived class car
class Car : Vehicle
{
    public Car(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }
    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days);
    }
}

//derived class bike
class Bike : Vehicle
{
    public Bike(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }
    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days);     
        
    }

}

//derived class truck
class Truck : Vehicle
{
    public Truck(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }
    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days);
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C098", "Tata", 300),
            new Bike("B001", "Hero", 150),
            new Truck("T154", "Ashok Leyland", 500)
        };
        int rentalDays = 2;
        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine($"{v.GetType().Name} ({v.Brand}) - Rent for {rentalDays}days: ${v.CalculateRent(rentalDays)}");
        }
    }
}