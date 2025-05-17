using System;

interface ISupportTicket
{
    void CreateTicket(string issue);
    void ResolveTicket(int ticketId);

}

class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Email: {issue}");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} via Email");
    }
}

class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Phone: {issue}");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} via Phone");
    }
}

class Program
{
    static void Main()
    {
        ISupportTicket emailSupport = new EmailSupport();
        ISupportTicket phoneSupport = new PhoneSupport();

        emailSupport.CreateTicket("Server busy");
        emailSupport.ResolveTicket(305);

        phoneSupport.CreateTicket("Network issue");
        phoneSupport.ResolveTicket(310);
    }
}