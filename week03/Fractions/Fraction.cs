using System;


public class Fraction
{
    private int _top;

    private int _bottom;

   public Fraction()//Constructor
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction( int wholeNumber)//Constructor
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)//Constructor
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public int SetTop(int top)
    {
        return _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public int SetBottom(int bottom)
    {
        return _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}

