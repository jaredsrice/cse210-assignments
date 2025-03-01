using System;

class Program
{
    static void Main()
    {
        // Print some text
        Console.Write("Hello, ");

        // Get the current cursor position
        int currentCursorPosition = Console.CursorLeft;
        Console.WriteLine($"Current Cursor Position: {currentCursorPosition}");

        // Move the cursor 5 positions to the right
        Console.CursorLeft += 5;
        Console.Write("World");

        // Get the new cursor position
        int newCursorPosition = Console.CursorLeft;
        Console.WriteLine($"\nNew Cursor Position: {newCursorPosition}");
    }
}
