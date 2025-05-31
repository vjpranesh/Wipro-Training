using System;

class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public int CorrectOptionIndex { get; set; }

    public Question(string text, List<string> options, int correctOptionIndex)
    {
        Text = text;
        Options = options;
        CorrectOptionIndex = correctOptionIndex;
    }
    
    public bool Ask()
    {
        Console.WriteLine(Text);
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{Options[i]}");
        }
        Console.Write("Your answer (1-4):");
        if (int.TryParse(Console.ReadLine(), out int userChoice) && userChoice >= 1 && userChoice <= Options.Count)
        {
            return (userChoice - 1) == CorrectOptionIndex;
        }
        else
        {
            Console.WriteLine("Invalid input. Question skipped");
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        List<Question> questions = new List<Question>
        {
            new Question("What is the capital of India?", new List<string>{"Delhi","Chennai","Mumbai","Pune"},0),
            new Question("How many colors in Rainbow?", new List<string>{"6", "5", "7", "8"}, 2)
        };

        var rand = new Random();
        var shuffledQuestions = new List<Question>(questions);
        for(int i = shuffledQuestions.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            (shuffledQuestions[i], shuffledQuestions[j]) = (shuffledQuestions[j], shuffledQuestions[i]);

        }
        int score = 0;
        Console.WriteLine("Quiz Started\n");

        foreach ( var question in shuffledQuestions)
        {
            if (question.Ask())
            {
                Console.WriteLine("Correct\n");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong\n");
            }
        }
        Console.WriteLine($"Quiz Completed. Your Score: {score}/{questions.Count}");
    }
}