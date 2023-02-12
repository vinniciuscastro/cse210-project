using System;

class Word {

    private string _text;
    private bool _isHidden;

    public Word(string text) {
        _text = text;
    }

    public void Hide() {
        _isHidden = true;

    }

    public string GetDisplay() {
        return _isHidden ? "***" : _text;
    }
}