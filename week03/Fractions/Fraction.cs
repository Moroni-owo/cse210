using System;

public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor with no parameters -> initializes as 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter (whole number) -> denominator = 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters (numerator and denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method that returns the fraction in string form (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method that returns the decimal value of the fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
