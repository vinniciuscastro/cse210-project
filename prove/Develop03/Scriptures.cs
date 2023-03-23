using System;

class Scriptures {
    private List<Word> _words = new List<Word> {};
    private Reff _reference; 

    public Scriptures(Reff reference,  string text) {
        _reference = reference;
        var words = text.Split(" ");
        foreach(var w in words){ 
            var word = new Word(w);
            _words.Add(word);
        }
    }
    public void HideWords(int count) {
        int listLength = _words.Count;
        Random random = new Random();
       
        for(int i=0; i < count; i++) {
            int index = random.Next(0, listLength -1);
            _words[index].Hide();

        }
        

        
    }

    public bool IsCompletelyHidden() {
        // I just need to know how haven't eaten their breakfast
        return true;
    }

    public void Display() {
        // string word = " ";
        _reference.GetDisplay();
        foreach (var w in _words) {
            string text = w.GetDisplay();
            Console.Write($"{text} ");
        }
    }
}