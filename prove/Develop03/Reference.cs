using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startingVerse;
    private int _endingVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = verse;
        _endingVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startVerse;
        _endingVerse = endVerse;
    }

    public string GetReferenceText()
    {
        if (_startingVerse == _endingVerse)
        {
            return $"{_book} {_chapter}:{_startingVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startingVerse}-{_endingVerse}";
        }
    }
}