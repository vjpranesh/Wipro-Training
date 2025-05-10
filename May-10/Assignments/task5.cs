using System;

class ChatBot
{
    public string Respond(string greeting)
    {
        return $"Hello: {greeting}";
    }
    public string Respond(string question, bool isFormal)
    {
        if (isFormal)
            return $"Thank you for the question.: {question}";
        else
            return $"Sure:{question}";
    }
    public string Respond(int number)
    {
        return $"You entered the number {number}. Good!";
    }
}

class Program
{
    static void Main()
    {
        ChatBot bot = new ChatBot();

        string greetingResponse = bot.Respond("Hi there");
        Console.WriteLine(greetingResponse);

        string casualQuestion = bot.Respond("what is the time now ?");
        Console.WriteLine(casualQuestion);

        string formalQuestion = bot.Respond("can you solve my request ?");
        Console.WriteLine(formalQuestion);

        string numericalQuery = bot.Respond("42");
        Console.WriteLine(numericalQuery);

    }
}