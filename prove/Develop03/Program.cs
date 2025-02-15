using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Here I created a list of scriptures to choose from and then randomly chose one to display. More scriptures can be added 
        // to the list if wanted. 
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding. In all thy ways acknowledge him, and he shall direct thy paths.")
        };

        Random rand = new Random();
        Scripture chosenScripture = scriptures[rand.Next(scriptures.Count)];
        Console.Clear();
        Console.WriteLine(chosenScripture.GetScriptureText());

        while (true)
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to quit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            chosenScripture.HideWords();
            Console.Clear();
            Console.WriteLine(chosenScripture.GetScriptureText());

            if (chosenScripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden! Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}