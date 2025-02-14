using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _referenceWords;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _referenceWords = new List<Word>();
    }
}
