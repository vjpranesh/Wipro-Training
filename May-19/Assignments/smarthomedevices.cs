using System;
using System.Diagnostics;

abstract class SmartDevice
{
    public abstract void TurnOn();
    public void ShowStatus()
    {
        Console.WriteLine("Device status : Active");
    }
}

interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}

class SmartLight : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Light turned on");

    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Lights do not support volume control ");
    }

    public void DecreaseVolume()
    {
        Console.WriteLine("Lights do not support volume control");
    }

}

class SmartSpeaker : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Speaker turned on");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Volume Increased");

    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Volume Decreased");
    }
}

class Program
{
    static void Main()
    {
        SmartDevice light = new SmartLight();
        SmartDevice speaker = new SmartSpeaker();

        IRemoteControl lightControl = (IRemoteControl)light;
        IRemoteControl speakerControl = (IRemoteControl)speaker;

        Console.WriteLine("SmartLight:");
        light.ShowStatus();
        light.TurnOn();
        lightControl.IncreaseVolume();
        lightControl.DecreaseVolume();

        Console.WriteLine("\nSmartSpeaker:");
        speaker.ShowStatus();
        speaker.TurnOn();
        speakerControl.IncreaseVolume();
        speakerControl.DecreaseVolume();
    }
}


