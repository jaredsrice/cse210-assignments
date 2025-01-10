using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int numberGrade = int.Parse(gradePercentage);

        char letter = ' ';

        if (numberGrade >= 90)
        {
            // Console.WriteLine("Yippe, you got an A!");
            letter = 'A';
        }
        else if (numberGrade >= 80)
        {
            // Console.WriteLine("Yippe, you got a B!");
            letter = 'B';
        }
        else if (numberGrade >= 70)
        {
            // Console.WriteLine("Eh, a C is passing.");
            letter = 'C';
        }
        else if (numberGrade >= 60)
        {
            // Console.WriteLine("I mean, a D is a letter.");
            letter = 'D';
        }
        else
        {
            // Console.WriteLine("F stands for failure, womp womp.");
            letter = 'F';
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (numberGrade >= 70)
        {
            Console.WriteLine("Winner winner chicken dinner, you passed!");

        }
        else
        {
            Console.WriteLine("Failure. Womp Womp.");
        }



    }
}