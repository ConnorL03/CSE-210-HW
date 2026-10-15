using System.Security.Cryptography;

public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 2;
    }
    public Fraction (int wholeNUmber)
    {
        _topNum = wholeNUmber;
        _bottomNum = 1;
    }

    public Fraction (int top, int bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }

    public int GetTop()
    {
        return _topNum;
    }
    public void SetTop(int top)
    {
        _topNum = top;
    }

    public int GetBottom()
    {
        return _bottomNum;
    }
    public void SetBottom(int bottom)
    {
        _bottomNum = bottom;
    }

    public string GetFractionString()
    {
        return ($"{_topNum}/{_bottomNum}");
    }
    
    public double GetDecimalValue()
    {
        double decimalValue = (double)_topNum / _bottomNum;
        return decimalValue;
    }
}