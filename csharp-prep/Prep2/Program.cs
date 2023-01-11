using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string prompt = Console.ReadLine();

        string valueInText = prompt;
        int grade = int.Parse(valueInText);
        string final = "";
        

        if (grade > 89) {
            final = "A";
        }

        else if (grade > 79) {
            final = "B";
        }

        else if (grade > 69) {
            final = "C";
        }

        else if (grade > 59) {
            final = "D";
        }
        else {
            final = "F";
        }
        Console.WriteLine($"Your grade is: {final}");
        
          if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
        


    }
}