public class Entry
{
    public string _prompt;
    public string _promptResponse;
    public DateTime _date; 
    public string _location;
    public string _mood;
    public string _weather;

    public Entry(string prompt, string promptResponse, string location, string mood, string weather)
    {
        _prompt = prompt;
        _promptResponse = promptResponse;
        _date = DateTime.Now;  
        _location = location;
        _mood = mood;
        _weather = weather;
    }

    public string GetEntryText()
    {
        return $"\n{_prompt} | {_promptResponse} | {_date} | {_location} | {_mood} | {_weather}";
    }
}



