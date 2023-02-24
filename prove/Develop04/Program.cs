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
                activity1.displayEnd(input);
                
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

    // public string GetName(){
    //     return _name;
    // }
    // public void SetName(string name) {
    //     _name = name;
    // }
    //  public string GetEnd(){
    //     return _endMessage;
    // }
    // public void SetEnd(string end) {
    //     _endMessage = end;
    // }
    // public int GetDuration(){
    //     return _duration;
    // }
    // public void SetDuration(int duration) {
    //     _duration = duration;
    // }
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

    public void displayEnd(int duration) {
        // how can I make the duration be set by the user input? 
        Console.WriteLine("");
        Console.WriteLine(_endMessage);
        GetReady();
        Console.WriteLine($"\nYou have completed {duration} seconds of Breathing Activity");
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
        // how to display it on the same line?
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

    public Listening(string end, string description, int duration): base(end,description, duration){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    
}

class Reflection: Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public Reflection(string end, string description, int duration): base(end, description , duration) {
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

    
}