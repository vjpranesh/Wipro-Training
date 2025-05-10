using System;

class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Operating appliance");
    }
}

class WashingMachine : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing clothes");
    }
}

class Program
{
    static void Main()
    {
        Appliance baseAppliance = new Appliance();
        baseAppliance.Operate();

        Appliance washer = new WashingMachine();
        washer.Operate();
    }
}
