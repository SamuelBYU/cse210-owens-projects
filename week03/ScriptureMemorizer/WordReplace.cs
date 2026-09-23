using System;
using System.Runtime.CompilerServices;

public class Word
//Keeps track of a single word and whether it is shown or hidden.
{
    private string _text;
    private bool _isHidden;

   
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string underscores = " ";

            for (int i = 0; i < _text.Length; i++)
            {
                underscores += "_";
            }

            return underscores;
        }
        else
        {
            return _text;
        }
        ;
    }


}