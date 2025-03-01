using System;

public class BreathingActivity: Activity

// Here I would also consider hitting my creativity boundary, I put a lot of effort into
// making sure that the breathing activity worked with as many numbers as possible, and
// wasn't obnoxiously long for a single cycle. For example, 6 seconds is one cycle of 2 seconds
// each, whereas 31 seconds is 2 cycles of 5 seconds each, with the last exhaling cycle
// being 6 seconds. Bunch of math and error prevention in here. 
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