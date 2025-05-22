using System;

class Program
{
    static void Main()
    {
        //create dictionary with name and phone number 
       Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        phoneBook.Add("Santhosh", "8442356788");
        phoneBook.Add("Arul", "9786546889");
        phoneBook.Add("Ashok", " 6546789078");

        Console.WriteLine("Phone Book Contacts:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }

        //ask for user name and display details
        Console.Write("\nEnter a name to search:");
        string name = Console.ReadLine();

        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine($"{name} phone number {phoneBook[name]}");
        }
        else
        {
            Console.WriteLine($"Contact {name} not found");
        }
    }
}