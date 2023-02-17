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
        string underscore = "_";
         if (_isHidden) {      
            return underscore;   
        } 
        else {
            return _text;   
        }
        }
}