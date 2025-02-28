using System;

public class BreathingActivity: Activity
{
    public BreathingActivity()
    : base ("Breathing Activity", "Practice relaxation and deep, controlled breathing by following this guided mediation.")
    {
    }

    public void StartBreathing()
    {
        base.StartActivity();

        while (true)
        {
            Console.WriteLine($"How long would you like to do the {_name}? (in seconds)");

            string durationInput = Console.ReadLine();

            if (int.TryParse(durationInput, out int duration) && duration > 0)
            {
                _duration = duration;
                break;
            }

            else
            {
                Console.WriteLine("Womp womp, enter a valid input.");
            }
        }

        int phaseTime = 5;
        int cycles = _duration / (3 * phaseTime);
        int remainder = _duration % (3 * phaseTime);

        Console.Clear();
        Console.WriteLine($"You will breathe for {_duration} seconds.\n");
        Console.WriteLine("Get ready...");
        Countdowns.SpinnerPause(3);

        for (int c = 0; c < cycles; c++)
        {
            Console.WriteLine("\nInhale...");
            Countdowns.SymbolCountdown(phaseTime);

            Console.WriteLine("Hold...");
            Countdowns.SymbolCountdown(phaseTime);

            Console.WriteLine("Exhale...");
            Countdowns.SymbolCountdown(phaseTime);
        }

        

        EndActivity();
    }
}