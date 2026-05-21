using System;

public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and Setter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return fraction as string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}