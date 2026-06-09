using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _gratitudePrompts;
    private Random _random;

    public GratitudeActivity()
        : base(
            "Gratitude",
            "This activity will help you focus on the positive things in your life and develop a greater sense of gratitude.")
    {
        _random = new Random();

        _gratitudePrompts = new List<string>
        {
            "Think of someone who has positively influenced your life.",
            "Think of something you are grateful for today.",
            "Think of a challenge that helped you grow.",
            "Think of a recent happy memory.",
            "Think of a talent or ability you are thankful to have."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        string prompt = GetRandomPrompt();

        Console.WriteLine("Consider the following:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("Take a moment to think deeply about it...");
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine("Now write down your thoughts.");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }

            if (DateTime.Now >= endTime)
            {
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You recorded {responses.Count} gratitude reflections.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _gratitudePrompts[_random.Next(_gratitudePrompts.Count)];
    }
}