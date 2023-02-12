using System;

class Program
{
    static void Main(string[] args)
    {
        Reff reference = new Reff("Proverbs",3, 5);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scriptures scripture = new Scriptures(reference, text);
        scripture.Display();

    }
}