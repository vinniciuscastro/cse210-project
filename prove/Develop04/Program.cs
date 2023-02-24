using System;

class Program
{
    static void Main(string[] args)
    {       
        bool loop = true;
        while (loop) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            int prompt = int.Parse(Console.ReadLine() ??"");
            if (prompt == 4){
                loop = false;
            }
            else if (prompt == 1){
                Console.Clear();
                Breathing activity1 = new Breathing("Well done!!", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 1 ,8, 4);
                Console.WriteLine($"{activity1.displaySummary()}");
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? "); 
                int input = int.Parse(Console.ReadLine() ??"");
                Console.Clear();
                Console.WriteLine("Get Ready...");
                activity1.GetReady();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(input);     

                DateTime current = DateTime.Now;
                while (current < futureTime) 
                {
                    Console.WriteLine("");
                    activity1.DisplayBreathIn();
                    activity1.DisplayBreathOut();
                    Console.WriteLine("");
                    current = DateTime.Now;
                }
                activity1.displayEnd(input, "Breathing");
            }

            else if (prompt == 2) {
                Console.Clear();
                Reflection activity2 = new Reflection("Well Done!!","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",1);
                Console.WriteLine($"{activity2.displaySummary()}");
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? "); 
                int input = int.Parse(Console.ReadLine() ??"");
                Console.Clear();
                Console.WriteLine("Get Ready...");
                activity2.GetReady();
                Console.WriteLine("");
                activity2.FirstPrompt();
                Console.Clear();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(input);     

                DateTime current = DateTime.Now;
                while (current < futureTime) 
                {
                    activity2.DisplayQuestion();
                    Console.Write("\n");
                    current = DateTime.Now;
                }
                
                activity2.displayEnd(input, "Reflection");

            }
            else if (prompt == 3) {
                Console.Clear();
                Listening activity3 = new Listening("Well Done!!","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",1);
                Console.WriteLine($"{activity3.displaySummary()}");
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? "); 
                int input = int.Parse(Console.ReadLine() ??"");
                Console.Clear();
                Console.WriteLine("Get Ready...");
                activity3.GetReady();
                Console.WriteLine("");
                activity3.Prompts();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(input);     

                DateTime current = DateTime.Now;
                Console.WriteLine($"You may begin in: ");
                while (current < futureTime) 
                {
                    activity3.userEntries();
                    current = DateTime.Now;
                }

                activity3.AllEntries();
                
                activity3.displayEnd(input, "Listening");
            }
            // Creativity: I decide to create an error message so if the user type something that it is not on the menu they can 
            else {
                Console.Clear();
                Reflection error = new Reflection("--","--",1);
                Console.WriteLine("______________________________________");
                Console.WriteLine("Error: Input not valid!");
                error.GetReady();
                Console.WriteLine("");
                Console.Write($"Please try again in: ");
                for (int i = 6; i > 0; i-- ) {
                    
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

            }

        }
}
}


class Activity {
    protected string _name;
    protected string _endMessage;
    protected string _description;
    // don't know what to do with the duration
    protected int _duration;

    protected Activity( string end, string description, int duration) {
        _endMessage = end;
        _description = description;
        _duration = duration;
        
    }
    public void GetReady() {
        
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < futureTime) 
        {
            string a = animations[i];
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count) {
                i = 0;
            }
        }
    }

    public string displaySummary() {
        string summary = $"{_name} \n \n{_description}";
        return summary;
    }

    public void displayEnd(int duration, string name) {
        // how can I make the duration be set by the user input? 
        Console.WriteLine("");
        Console.WriteLine(_endMessage);
        GetReady();
        Console.WriteLine($"\nYou have completed {duration} seconds of {name} Activity");
        GetReady();
    }
}

class Breathing: Activity {
    private int _breathIn;
    private int _breathOut;



    public Breathing(string end, string description,int duration, int breathIn, int breathOut): base(end, description, duration) {
        _name = "Welcome to the Breathing Activity";
        _breathIn = breathIn;
        _breathOut = breathOut;
    }

    public void DisplayBreathIn() {
       
        Console.Write($"Breathe in...");
        for (int i = _breathIn; i > 0; i-- ) {
            
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }  
    }

    public void DisplayBreathOut() {
        Console.Write($"\nNow breathe out...");
        for (int i = _breathOut; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }  
    }

}

class Listening: Activity {
    private List<string> _prompts = new List<string>();
    private List<string> entries = new List<string>();

    public Listening(string end, string description, int duration): base(end,description, duration){
        _name = "Welcome to the Listening Activity";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void Prompts() {
        Random random = new Random();
        Console.WriteLine("Consider the following prompt:\n");
        int promptMessage = random.Next(_prompts.Count);
        string prompts_ = _prompts[promptMessage];
        Console.WriteLine($"--- {prompts_} ---\n");
    }
    public void userEntries() {
        Console.Write(">");
        string userInput = Console.ReadLine();
        entries.Add(userInput);
        
    }
    public void AllEntries() {
        int count = entries.Count;
        Console.WriteLine("You listed " + count + " items!");
    }
    
}

class Reflection: Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public Reflection(string end, string description, int duration): base(end, description , duration) {
        _name = "Welcome to the Reflection Activity";
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        }

    public void FirstPrompt() {
        Random random = new Random();
        Console.WriteLine("Consider the following prompt:\n");
        int promptMessage = random.Next(_prompts.Count);
        string prompts_ = _prompts[promptMessage];
        Console.WriteLine($"--- {prompts_} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder in each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        for (int i = 5; i > 0; i-- ) {
            
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
    }

    public void DisplayQuestion() {
        Random random = new Random();
        int message = random.Next(_questions.Count);
        string questions_ = _questions[message];
        Console.Write($"> {questions_}");
        GetReady();
        
    }
}