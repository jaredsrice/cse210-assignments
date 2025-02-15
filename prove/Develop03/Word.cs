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
        if (_hidden == 0)
        {
            _hidden = 1;
        }
    }

    public string GetText()
    {
        if (_hidden == 1)
        {
            return "_____"; 
        }
        else
        {
            return _text; 
        }
    }
}