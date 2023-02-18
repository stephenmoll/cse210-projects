using System;

public class Fraction {

    // Attributes
    private int _topNum;
    private int _bottomNum;


    // Constructors

    public Fraction() {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int wholeNumber) {
        _topNum = wholeNumber;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom) {

        _topNum = top;
        _bottomNum = bottom;

    }

    // Methods 

    public string GetFractionString() {
        string text = $"{_topNum}/{_bottomNum}";
        return text;
    }

    public double GetDecimalValue() {
        return (double)_topNum / (double)_bottomNum;
    }

}
