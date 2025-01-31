using System;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void ViewEntries()
    {
        if (_entries.Count == 0) 
        {
            Console.WriteLine("No journal entries found.");
        }

        else
        {
            foreach (Entry entry in _entries) 
            {
                Console.WriteLine($"\n{entry._prompt} | {entry._response} | {entry._date} | {entry._location} | {entry._mood} | {entry._weather}");
            }
        }
    }

    public void AddEntry(string prompt, string promptResponse, string location, string mood, string weather)
    {
        Entry newEntry = new Entry(prompt, promptResponse, location, mood, weather);  
        _entries.Add(newEntry);
    }


    public void SaveJournal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                string entryText = entry.GetEntryText();  
                outputFile.WriteLine(entryText);
            }
        }
        Console.WriteLine("Journal has been saved.");
    }
    public void LoadJournal(string filename)
    {
        if (File.Exists(filename))
        {
            string fileContent = File.ReadAllText(filename);
            string[] lines = fileContent.Split('\n');

            _entries.Clear();

            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] parts = line.Split('|');

                    if (parts.Length == 6)
                    {
                        Entry entry = new Entry(parts[0], parts[1], parts[3], parts[4], parts[5]);
                        _entries.Add(entry);
                    }
                }
            }

        Console.WriteLine("Journal has been loaded.\n");
        ViewEntries();
        }

        else
        {
            Console.WriteLine("File not found.");
        }
    }
}