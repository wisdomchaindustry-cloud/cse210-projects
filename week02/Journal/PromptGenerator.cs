using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>();

    private Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person you interacted with today?");
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("How did you see progress in your goals today?");
        _prompts.Add("What challenged you today and how did you handle it?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("If you could redo one moment today, what would it be?");
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}