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

        int numberOfCycles = _duration / 3;

        int remainder = _duration % 3;
        int baseDuration = _duration / (numberOfCycles * 3);

        int inhale = baseDuration;
        int hold = baseDuration;
        int exhale = baseDuration;

        if (remainder > 0)
        {
            inhale += 1;
        }

        if (remainder > 1)
        {
            hold += 1;
        }

        Console.Clear();
        Console.WriteLine($"You will breathe for {_duration} seconds.\n");
        Console.WriteLine("Get ready...");
        Countdowns.SpinnerPause(3);

        for (int cycle = 0; cycle < numberOfCycles; cycle++)
        {
            Console.WriteLine("\nInhale...");
            Countdowns.SymbolCountdown(inhale);

            Console.WriteLine("Hold...");
            Countdowns.SymbolCountdown(hold);

            Console.WriteLine("Exhale...");
            Countdowns.SymbolCountdown(exhale);
        }

        if (remainder > 0)
        {
            Console.WriteLine("\nInhale...");
            Countdowns.SymbolCountdown(inhale);

            Console.WriteLine("Hold...");
            Countdowns.SymbolCountdown(hold);

            Console.WriteLine("Exhale...");
            Countdowns.SymbolCountdown(exhale); 
        }

        EndActivity();
    }
}