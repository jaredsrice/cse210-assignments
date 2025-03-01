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

        int minPhaseTime;

        if (_duration > 14)
        {
            minPhaseTime = 5;
        }

        else 
        {
            minPhaseTime = 3;
        }

        int maxPhaseTime = 10;
        int scaledPhaseTime = _duration / 9;

        if (scaledPhaseTime < minPhaseTime)
        {
            scaledPhaseTime = minPhaseTime;
        }

        else if (scaledPhaseTime > maxPhaseTime)
        {
            scaledPhaseTime = maxPhaseTime;
        }

        int cycles = _duration / (3 * scaledPhaseTime);

        if (cycles < 1)
        {
            cycles = 1;
        }

        int phaseTime = _duration / (3 * cycles);
        int remainder = _duration % (3 * cycles);

        Console.Clear();
        Console.WriteLine("You will breathe for " + _duration + " seconds.\n");
        Console.WriteLine("Get ready...");
        Countdowns.SpinnerPause(3);

        for (int c = 0; c < cycles; c++)
        {
            Console.WriteLine("\nInhale...");
            Countdowns.SymbolCountdown(phaseTime);

            Console.WriteLine("Hold...");
            Countdowns.SymbolCountdown(phaseTime);

            Console.WriteLine("Exhale...");

            if (c == cycles - 1)
            {
                Countdowns.SymbolCountdown(phaseTime + remainder);
            }
            else
            {
                Countdowns.SymbolCountdown(phaseTime);
            }
        }

        EndActivity();
    }
}