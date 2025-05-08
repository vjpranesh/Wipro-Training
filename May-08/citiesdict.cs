using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string>
        {
            { "Mumbai", "Maharashtra" },
            { "Bangalore", "Karnataka" },
            { "Chennai", "Tamil Nadu" },
            { "Kolkata", "WestBengal" },
            { "Hyderabad", "Telangana" }

         };
        Console.WriteLine("Indian Cities and their States:");
        foreach ( var city in cities)
        {
            Console.WriteLine($"{city.Key} is in {city.Value}");
        }

        if (cities.ContainsKey("Chennai")) ;
        {
            Console.WriteLine("Chennai is present in the dictionary.");
        }
           
        
    }
}
