using System;

abstract class TicketBooking
{
    public abstract void BookTicket(int seats);
    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking tickets");
    }
}

class BusBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking  x bus tickets");
    }
}

class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking  x flight tickets");
    }
}

class Program
{
    static void Main()
    {
        TicketBooking busBooking = new BusBooking();
        TicketBooking flightBooking = new FlightBooking();

        busBooking.ShowBookingInfo();
        busBooking.BookTicket(5);

        Console.WriteLine();

        flightBooking.ShowBookingInfo();
        flightBooking.BookTicket(5);
    }
}