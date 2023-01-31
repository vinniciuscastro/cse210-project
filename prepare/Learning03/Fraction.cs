using System;

class Fraction {
    private int _top;
    private int _bottom;

     public void fraction() {
        _top = 1; 
        _bottom = 1;
    }
    public void fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }
    public void fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }
}