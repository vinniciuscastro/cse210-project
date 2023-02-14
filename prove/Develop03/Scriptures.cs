using System;

class Scriptures {
    private List<Word> _word = new List<Word> {};
    private Reff _reference; 

    public Scriptures(Reff reference,  string text) {
        _reference = reference;
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
        // string word = " ";
        _reference.GetDisplay();
        foreach (var w in _word) {
            string text = w.GetDisplay();
            Console.Write($"{text} ");
        }
    }
}