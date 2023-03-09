using System;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> _allGoals = new List<Goal>(); 
        int total_points = 0;
        bool loop = true;
        while (loop){
            Console.WriteLine($"You have {total_points} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("What would like to do? ");
            int prompt = int.Parse(Console.ReadLine() ??"");
            if (prompt == 6) {
                loop = false;  
            }
            else if (prompt == 1) {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
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
                else if (prompt == 2) {
                    Console.Write("What is the name of your goal? ");
                    string goal = Console.ReadLine() ??"";
                    Console.Write("What is a short description of it? ");
                    string describe  = Console.ReadLine() ??"";
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine() ??"");
                    Eternal eternal = new Eternal(points, goal, describe);
                    _allGoals.Add(eternal);
                }
                else if (prompt == 3) {
                    Console.Write("What is the name of your goal? ");
                    string goal = Console.ReadLine() ??"";
                    Console.Write("What is a short description of it? ");
                    string describe  = Console.ReadLine() ??"";
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine() ??"");
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int quantity = int.Parse(Console.ReadLine() ??"");
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int bonus = int.Parse(Console.ReadLine() ??"");
                    Checklist checklist = new Checklist(points, goal, describe, quantity, bonus);
                    _allGoals.Add(checklist);
                }
            }
            else if (prompt == 2) {
                
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

//         using (StreamWriter outputFile = new StreamWriter(fileName))
//     {
//         foreach (var entry in main_list) {
//             string line = $"{entry.timestamp}@{entry.content}@{entry._prompt}";
//             outputFile.WriteLine(line);
//     }
    

// }
    }
    static void Load(){
          string filename;
        Console.Write("What is the filename? ");
        filename = Console.ReadLine() ??""; 
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            // string[] parts = line.Split("@");
            // Entry info = new Entry();
            // info.timestamp = parts[0];
            // info.content = parts[1];
            // info._prompt = parts[2];
            // main_list.Add(info);
            

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
        Console.WriteLine($"[{_complete}] {_goal} ({_description})");
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
    public Checklist(int points, string goal, string description, int quantity, int bonus):base (points, goal, description) {
        _quantity = quantity; 
        _bonus = bonus; 
}
    public override void Display()
    {
        Console.WriteLine($"[{_complete}] {_goal} ({_description}) ---Currently completed: {_quantity}");
    }
}