using System;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "What is one thing you would like to do better tomorrow?",
            "What is something you learned today?",
            "What made you smile today?"
        };

        _random = new Random();
    }

    public string GetPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
