using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(0, 10);
        Console.WriteLine($"What is the magic number? {magicNumber}");
        
        bool keepPlaying = true;

        while(keepPlaying) {
            Console.Write("What is your guess? ");
            int prompt = int.Parse(Console.ReadLine() ??"");

            if (magicNumber == prompt) {
                Console.WriteLine("Nice! You guessed it!");
                keepPlaying = false; 
            } else if (magicNumber > prompt) {
                Console.WriteLine("Higher");
           } else {
                 Console.WriteLine("Lower");
           }
               
           }

           



    }
}