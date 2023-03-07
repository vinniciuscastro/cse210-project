using System;

class Program
{
    static void Main(string[] args)
    {


        bool loop = true;
        while (loop){
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
    protected List<String> _allGoal = new List<string>(); 
    protected bool _complete = false; 

    public Goal (int points, string goal, string description, bool complete) {
        _points = points; 
        _description = description; 
        _complete = complete; 

    }
    virtual public void GetGoalFromUser() {

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

    public Simple(int points, string goal, string description, bool complete):base (points, goal, description, complete) {

}
}
class Eternal: Goal {
    public Eternal(int points, string goal, string description, bool complete):base (points, goal, description, complete) {

}

}

class Checklist: Goal { 
    public Checklist(int points, string goal, string description, bool complete):base (points, goal, description, complete) {

}

}