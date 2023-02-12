using System;

class Scriptures {
    private List<Word> _word = new List<Word> {};

    public Scriptures(Reff reference,  string text) {
        var words = text.Split(" ");
        foreach(var w in words){ 
            var word = new Word(w);
            _word.Add(word);
        }
    }
    public void HideWords(int count) {
        
    }

    // public bool IsCompletelyHidden() {

    // }

    public void Display() {
        
    }

}