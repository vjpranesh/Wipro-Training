using System;

class SmartDevice
{
    public string DeviceName;
    public bool PowerStatus;

    public void TogglePower()
    {
        PowerStatus = !PowerStatus;
        Console.WriteLine($"{DeviceName} power is now {(PowerStatus ? "ON" : "OFF")}");

    }
}

class SmartLight : SmartDevice
{
    public int Brightness;
    public void SetBrightness(int level)
    {
        if (PowerStatus)
        {
            Brightness = level;
            Console.WriteLine($"{DeviceName} brightness set to {Brightness}");
        }
        else
        {
            Console.WriteLine($"{DeviceName} is OFF. Turn it ON to adjust brightness. ");
        }
        
    }
}

class SmartThermostat : SmartDevice
{
    public double Temperature;
    public void SetTemperature(double temp)
    {
        if (PowerStatus)
        {
            Temperature = temp;
            Console.WriteLine($"{DeviceName} temrperature set to {Temperature} C");
         }
        else
        {
            Console.WriteLine($"{DeviceName} is OFF. Turn it ON to adjust temperature.");
        }
    }
}

class Program
{
    static void Main()
    {
        SmartLight livingRoomLight = new SmartLight();
        livingRoomLight.DeviceName = "Living Room Light";
        livingRoomLight.TogglePower();
        livingRoomLight.SetBrightness(45);

        Console.WriteLine();

        //creating thermostat object 
        SmartThermostat homeThermostat = new SmartThermostat();
        homeThermostat.DeviceName = " Home Thermostat";
        homeThermostat.TogglePower();
        homeThermostat.SetTemperature(21.5);

        Console.WriteLine();

        livingRoomLight.TogglePower();
        homeThermostat.TogglePower();
    }
}