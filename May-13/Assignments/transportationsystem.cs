using System;
using System.ComponentModel;
interface ITransport
{
   void Start();
   void Stop();
}

//interface in bus class
class Bus : ITransport
{
  public void Start()
  {
   Console.WriteLine("Bus is starting");
  }
  public void Stop()
  {
    Console.WriteLine("Bus is stopping");
  }
}

//interface in train class
class Train : ITransport
{
  public void Start()
    {
        Console.WriteLine("Train is starting");
    }
  public void Stop()
  {
   Console.WriteLine("Train is stopping");
  }
}

class Program
{
  static void Main(string[] args)
  {
    ITransport bus = new Bus();
    bus.Start();
    bus.Stop();

    ITransport train = new Train();
    train.Start();
    train.Stop();
  }
}
