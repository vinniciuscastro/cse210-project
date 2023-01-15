using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();

        DisplayResult(name, number);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName (){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine() ?? "";
        return name;
        
    }
    static int PromptUserNumber() { 
        Console.Write("Please enter your favorite number: ");
        int Number = int.Parse(Console.ReadLine() ??"");
        return Number;
    }
    static int SquareNumber(int numb) {
        int result = (int)Math.Pow(numb, 2);
        return result;
    }

    static void DisplayResult(string name, int number) {
        int square = SquareNumber(number);
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
