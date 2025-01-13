using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

            Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");

            do
            {
                Console.Write("\nEnter a Number: ");
                number = int.Parse(Console.ReadLine());

                if (number != 0)
                {
                    numbers.Add(number);
                }
            }
            while (number != 0);

        //  Computing the Sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        
        Console.WriteLine($"\nThe sum is: {sum} ");

        // Computing the Average
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"\nThe average is: {average} ");

        // Finding the largest number
        // int maxNumber = numbers.Max();

        int maxNumber = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

        Console.WriteLine($"\nThe largest number is: {maxNumber}\n");

        
    }
}