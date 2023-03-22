using System;

class Program
{
    static void Main(string[] args)
    {
        Reff reference = new Reff("Proverbs",3, 5);
        string text = " Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scriptures scripture = new Scriptures(reference, text);
        string quit = "quit";
        Console.Clear();
        scripture.Display();
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input;
            Console.Write("> ");
            input = Console.ReadLine() ??"";
            scripture.HideWords(1); 
        while (input != quit) {
            Console.Clear();
            scripture.Display();
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            Console.Write("> ");
            input = Console.ReadLine() ??"";
            scripture.HideWords(3); 
            
        }

    }
}