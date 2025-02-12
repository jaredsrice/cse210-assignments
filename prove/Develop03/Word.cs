using System;

public class Word
{
    private string _text;
    private int _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = 0;
    }

    public void HideWord()
    {
        _hidden = 1;
    }

    public string GetText()
    {
        if (_hidden == 1)
        {
            return "____";
        }
        return _text;
    }
}