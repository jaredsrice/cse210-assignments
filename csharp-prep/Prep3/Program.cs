using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
        {
          Console.WriteLine("Lower");
        }

        else if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You got it!");
        }

        } while (guess != number);

    }
}