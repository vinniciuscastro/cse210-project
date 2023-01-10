using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string prompt = Console.ReadLine();

        string valueInText = prompt;
        int grade = int.Parse(valueInText);

        Console.WriteLine("");

        if (grade > 89) {
            Console.WriteLine("You got an A congrats");
        }

        else if (grade > 79) {
            Console.WriteLine("You got a B great job");
        }

        else if (grade > 69) {
            Console.WriteLine("You got a C");
        }

        else if (grade > 59) {
            Console.WriteLine("You got a D you failed the class");
        }
        else if (grade < 60) {
            Console.WriteLine("You got a F you failed the class");
        }

        


    }
}