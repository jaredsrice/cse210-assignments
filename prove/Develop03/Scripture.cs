using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _referenceWords;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _referenceWords = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _referenceWords.Add(new Word(word));
        }
    }

    public string GetScriptureText()
    {
        string text = _reference.GetReferenceText() + "\n";

        foreach (Word word in _referenceWords)
        {
            text += word.GetText() + " ";
        }

        return text.Trim();
    }
    public void HideWords()
    {
        Random rand = new Random();

        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _referenceWords)
        {
            if (word.GetText() != "_____")
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count > 0)
        {
            int wordIndex = rand.Next(visibleWords.Count);

            visibleWords[wordIndex].HideWord();
        }
    }
    public bool AllWordsHidden()
    {
        foreach (Word word in _referenceWords)
        {
            if (word.GetText() != "_____")
            {
                return false; 
            }
        }

        return true;
    }
}