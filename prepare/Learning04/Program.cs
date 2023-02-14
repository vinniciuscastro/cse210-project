using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment("Vinnicius Castro", "Macbeth");
        Writing assignment = new Writing("Vinnicius Castro", "Macbeth","Freytag's Triangle applied to Macbeth");
        Console.WriteLine($"{student1.GetSummary()}");
        Console.WriteLine($"{assignment.GetWritingInfo()}");
    }
}

