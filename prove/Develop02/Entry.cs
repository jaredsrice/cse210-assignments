using System;

public class Entry
{
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
    }

    public string GetEntryText()
    {
        return _prompt + " | " + _response;
    }
}