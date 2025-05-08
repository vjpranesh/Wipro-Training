using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>
        {
            {"Johnny", "8989898989" },
            {"Ram", "9797979797" },
            {"Rita", "6464646464" },
            {"Singh", "8787878787" },
            {"Alice", " 3434343434" }
        };

        string nameToUpdate = "Singh";
        if (contacts.ContainsKey(nameToUpdate))
        {
            contacts[nameToUpdate] = "7878787878";
            Console.WriteLine($"Phone number for {nameToUpdate} updated to {contacts[nameToUpdate]}");
        }
        else
        {
            Console.WriteLine($"{nameToUpdate} not found in contacts");
        }

        string nameToCheck = "Ram";
        if (contacts.ContainsKey(nameToCheck))
        {
            Console.WriteLine($"\n{nameToCheck} exists. Phone:{contacts[nameToCheck]}");
        }
        else
        {
            Console.WriteLine($"\n{nameToCheck} not exists");
        }

        Console.WriteLine("\nAll Contacts");
        foreach ( var contact in contacts)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone:{contact.Value}");
        }
    }
}