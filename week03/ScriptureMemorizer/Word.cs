using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        int textLength = _text.Length;
        _text = new string('_', textLength);

    }

    public void Show()
    {
        
    }

    public bool isHidden()
    {
        _isHidden = _text.Contains("_");
        return _isHidden;
    }

    public string GetDisplaytext()
    {
        return _text;
    }

    public override string ToString()
    {
        return _text;
    }
}