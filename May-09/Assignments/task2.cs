using System;

// base class
class Vehicle 
{
    public string Make;
    public string Model;
    public void DisplayVehicle()
    {
        Console.WriteLine("Make: " + Make);
        Console.WriteLine("Model: " + Model);
    }
}

class Car : Vehicle
{
    public string FuelType;

    //display car specific details 
    public void DisplayCar()
    {
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();

        //setting values
        myCar.Make = "Tata";
        myCar.Model = "Curvv";
        myCar.FuelType = "Petrol";

        //display complete details 
        Console.WriteLine("Vehicle Details:");
        myCar.DisplayVehicle();

        Console.WriteLine("\nCar Details:");
        myCar.DisplayCar();
    }
}


//adding class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ConsoleApp3
{
    class Car : Vehicle
    {
        public string FuelType;

        //display car specific details 
        public void DisplayCar()
        {
            Console.WriteLine("Fuel Type: " + FuelType);
        }
    }
}






