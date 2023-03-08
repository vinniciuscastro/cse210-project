using System;

class Reff {

    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse; 
    public Reff(string book, int chapter, int start) {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
    }
    public Reff(string book, int chapter, int start, int end) {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }
    public void GetDisplay() {
        Console.Write($"{_book} {_chapter}: {_startVerse}" + (_endVerse != null ? $"-{_endVerse}" : ""));

    }
}