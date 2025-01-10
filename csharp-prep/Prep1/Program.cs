using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWhat is your first name?");
        string first_name = Console.ReadLine();

        Console.WriteLine("\nWhat is your last name?");
        string last_name = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"\nYour name is {last_name}, {first_name} {last_name}\n");
    
    }
}
    