using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool keepPlaying = true;
        List<int> numbers;
        numbers = new List<int>();

        while(keepPlaying) {
            Console.Write("Enter number: ");
            int prompt = int.Parse(Console.ReadLine() ??"");
            numbers.Add(prompt);

            if (prompt == 0) {
                int sum = numbers.Sum();
                Console.WriteLine($"The sum is: {sum}");
                float average = ((float)sum) / (numbers.Count - 1);
                Console.WriteLine($"The average is: {average}");
                int largest = numbers.Max();
                Console.WriteLine($"The largest number is: {largest}");
                keepPlaying = false;

        
            }
        }

    }
}