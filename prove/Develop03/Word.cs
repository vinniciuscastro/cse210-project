using System;

class Word {

    private string _text;
    private bool _isHidden;

    public Word(string text) {
        _text = text;
        _isHidden = false; 
    }

    public void Hide() {
        _isHidden = true;
        int textLength = _text.Length; 
        string underscores = "";
        
        for (int j = 0; j < textLength; j++) {
            underscores += "_";  
            }
        _text = underscores;          

    }
    

    public string GetDisplay() {
        return _text;     
    }
        
      
}       