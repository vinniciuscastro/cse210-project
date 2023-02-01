using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction numb = new Fraction();


        
        Console.WriteLine(numb.GetFractionString());
        Console.WriteLine(numb.GetDecimalValue());
        
        numb.SetBottom(5);
        numb.SetTop(5);
        Console.WriteLine(numb.GetFractionString());
        Console.WriteLine(numb.GetDecimalValue());
        
        numb.SetBottom(4);
        numb.SetTop(3);
        Console.WriteLine(numb.GetFractionString());
        Console.WriteLine(numb.GetDecimalValue());

        numb.SetBottom(3);
        numb.SetTop(1);
        Console.WriteLine(numb.GetFractionString());
        Console.WriteLine(numb.GetDecimalValue());

    }
}