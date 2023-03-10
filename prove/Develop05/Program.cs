using System;

class Program
{
    private static IEnumerable<object> _allGoals;

    static void Main(string[] args)
    {

        List<Goal> _allGoals = new List<Goal>(); 
        int total_points = 0;
        bool loop = true;
        while (loop){
            Console.WriteLine("");
            Console.WriteLine($"You have {total_points} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("What would like to do? ");
            int prompt = int.Parse(Console.ReadLine() ??"");
            if (prompt == 6) {
                loop = false;  
            }
            else if (prompt == 1) {
                Console.WriteLine("");
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int answer = int.Parse(Console.ReadLine() ??"");
                if (answer == 1) {
                    Console.Write("What is the name of your goal? ");
                    string goal = Console.ReadLine() ??"";
                    Console.Write("What is a short description of it? ");
                    string describe  = Console.ReadLine() ??"";
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine() ??"");
                    Simple simple = new Simple(points, goal, describe);
                    _allGoals.Add(simple);
                    


                }
                else if (answer == 2) {
                    Console.Write("What is the name of your goal? ");
                    string goal = Console.ReadLine() ??"";
                    Console.Write("What is a short description of it? ");
                    string describe  = Console.ReadLine() ??"";
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine() ??"");
                    Eternal eternal = new Eternal(points, goal, describe);
                    _allGoals.Add(eternal);
                }
                else if (answer == 3) {
                    Console.Write("What is the name of your goal? ");
                    string goal = Console.ReadLine() ??"";
                    Console.Write("What is a short description of it? ");
                    string describe  = Console.ReadLine() ??"";
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine() ??"");
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int quantity = int.Parse(Console.ReadLine() ??"");
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine() ??"");
                    Checklist checklist = new Checklist(points, goal, describe, quantity, bonus);
                    _allGoals.Add(checklist);
                }
            }
            else if (prompt == 2) {
                if (_allGoals.Count == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You don't have any goals yet");
                    }
                else {
                    int numb = 1;
                    foreach (var goal in _allGoals){
                        
                        
                        Console.Write($"     {numb}. ");
                        goal.Display();
                        numb++;

                    }
                }
                Animation();

                
            }
            else if (prompt == 3) {
                
            }
            else if (prompt == 4) {
                
            }
            else if (prompt == 5) {
                
            }
        }
       
    }
    static void Save() {
        string fileName;
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine() ??""; 

    //     using (StreamWriter outputFile = new StreamWriter(fileName))
    // {
    //     foreach (var entry in _allGoals) {
    //         string line = $"[{entry._complete}]@{entry.}@{entry._prompt}";
    //         outputFile.WriteLine(line);
    // }
    

    // }
    }
    // static void Load(){
    //       string filename;
    //     Console.Write("What is the filename? ");
    //     filename = Console.ReadLine() ??""; 
    //     string[] lines = System.IO.File.ReadAllLines(filename);
        
    //     foreach (string line in lines)
    //     {
    //         // string[] parts = line.Split("@");
    //         // Entry info = new Entry();
    //         // info.timestamp = parts[0];
    //         // info.content = parts[1];
    //         // info._prompt = parts[2];
    //         // main_list.Add(info);
            

    //     }
    
    // }
    static void Animation() {
        
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
}
class Goal {
    protected int _points; 
    protected string _goal; 
    protected  string _description;
    protected bool _complete = false; 

    public Goal (int points, string goal, string description) {
        _points = points; 
        _description = description; 
        _goal = goal;
        

    }
    virtual public void Display() {
        
    }
    virtual public void RecordEvent() {

    }

    virtual public bool IsComplete() {
        _complete = true; 
        return _complete;
    }
}

class Simple: Goal {

    public Simple(int points, string goal, string description):base (points, goal, description) {
}
    public override void Display()
    {
       string checkmark = " ";
       if (_complete) {   
        checkmark = "X";
        }
        Console.WriteLine($"[{checkmark}] {_goal} ({_description})");
    }
} 
    
class Eternal: Goal {
    public Eternal(int points, string goal, string description):base (points, goal, description) {

}
    public override void Display()
    {
        
        Console.WriteLine($"[{_complete}] {_goal} ({_description})");
    }

}

class Checklist: Goal { 
    private int _quantity; 
    private int _bonus;
    private int _accomplished;
    public Checklist(int points, string goal, string description, int quantity, int bonus):base (points, goal, description) {
        _quantity = quantity; 
        _bonus = bonus; 
        _accomplished = 0;

}
    public override void Display()
    {
        Console.WriteLine($"[{_complete}] {_goal} ({_description}) ---Currently completed: {_accomplished}/{_quantity}");
    }
}