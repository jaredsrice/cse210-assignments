using System;

public class Countdowns
{
   public static void SpinnerPause(int seconds)
   {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> animation = new List<string>{"|", "/", "_", "\\", "|", "/", "‾", "\\"};

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string decals = animation[i];
            Console.Write(decals);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    public static void SymbolCountdown(int seconds)
    {
        int symbolStart = Console.CursorLeft;

        for (int i = 0; i < seconds; i++)
        {
            Console.Write("▌");
        }
        
        for (int i = seconds; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.SetCursorPosition(symbolStart + i - 1, Console.CursorTop);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}