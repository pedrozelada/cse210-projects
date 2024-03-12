using System.Security.Cryptography;

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

     public int GetTop()
    {
        return _top;
    }

    public void SetTop(int topu)
    {
        _top = topu;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottomu)
    {
        _bottom = bottomu;
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double  GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }

}