using System;

public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string>
    {
       "What are you grateful for today?",
       "Who are people that you appreciate?", 
       "Who are people that you have helped this week?",
       "What have you accomplished this week?", 
       "What are you looking forward to in the future?",
       "What are you proud of?",
       "What have you forgottten to acknowledge that you're actually very happy with?"
    };

    public ListingActivity()
    : base("Listing Activity", "Given the prompt, come up with as many responses as you can in the allotted time.")
    {
    }

    public void StartListing()
    {
        base.StartActivity();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.Clear();
        Console.WriteLine(prompt);
        Console.WriteLine($"You'll have {_duration} seconds to list as many responses as you can.");
        Countdowns.SpinnerPause(5);

        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"\nTime over. You listed {responses.Count} responses, nice work.\n");
        EndActivity();
    }
}