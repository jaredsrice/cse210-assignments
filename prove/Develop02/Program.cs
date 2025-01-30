using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while(true)
        {

            Console.WriteLine("\n1. Write a new Entry"); 
            Console.WriteLine("2. View Current Entries");
            Console.WriteLine("3. Save Entries to Journal");  
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit\n");
            Console.Write("Please Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
           {
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine("\nPrompt: " + prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                journal.AddEntry(prompt, response);
                Console.WriteLine("\nEntry added.");
            }

            else if (choice == "2")
            {
                journal.ViewEntries();
            }
            
            else if (choice == "3")
            {
                Console.Write("Enter a filename to save your journal: ");
                string filename = Console.ReadLine();
                journal.SaveJournal(filename);
            }


            else if (choice == "4")
            {
                Console.Write("Enter a filename to load a journal: ");
                string filename = Console.ReadLine();
                journal.LoadJournal(filename);
            }

            else if (choice == "5")
            {
                Console.WriteLine(" ByE ByE"); 
                break;
            }

            else
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }
    }
}