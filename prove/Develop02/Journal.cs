using System;

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
                Console.WriteLine("\n" + entry._prompt + " | " + entry._response + "\n");
            }
        }
    }

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }

    public void SaveJournal(string filename)
{
    string allEntries = ""; 

    foreach (Entry entry in _entries)
    {
        string entryText = entry._prompt + "|" + entry._response + "\n"; 
        allEntries += entryText; 
    }

    File.WriteAllText(filename, allEntries); 
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
                if (parts.Length == 2) 
                {
                    Entry entry = new Entry(parts[0], parts[1]); 
                    _entries.Add(entry); 
                }
            }
        }

        Console.WriteLine("Journal has been loaded.");
        ViewEntries();
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}

}