using System;

public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you were truly happy.",
        "Recall a moment when you overcame a challenge.",
        "Remember a time when you helped someone in need.",
        "Think of a situation that made you grow as a person.",
        "Reflect on a recent achievement that made you proud.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a moment when you stepped outside your comfort zone.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"      
    };

    public ReflectingActivity()
    : base ("Reflecting Activity", "Take some time to think about past experiences to gain insights and new perspectives. Please have your duration be a multiple of 10.")
    {
    }

    public void StartReflecting()
    {
        base.StartActivity();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.Clear();
        Console.WriteLine("Reflect on the following prompt: ");
        Console.WriteLine("\n" + "---" + prompt + "---" + "\n");
        Console.WriteLine("When you're ready, press enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        List<string> availableQuestions = new List<string>(_questions);

        while (DateTime.Now < endTime && availableQuestions.Count > 0)
        {
            int questionIndex = random.Next(availableQuestions.Count);
            string question = availableQuestions[questionIndex];
            availableQuestions.RemoveAt(questionIndex);

            Console.WriteLine("\n" + question);
            Countdowns.SymbolCountdown(10);
        }
        EndActivity();
    }
}