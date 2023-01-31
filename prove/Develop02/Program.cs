using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu startEnd = new Menu();
        startEnd.Run();


    }
}

class Journal 
{
  public List<Entry> main_list = new List<Entry> {};


  public void Save() {
    string fileName;
    Console.Write("What is the filename? ");
    fileName = Console.ReadLine() ??""; 

    using (StreamWriter outputFile = new StreamWriter(fileName))
{
    foreach (var entry in main_list) {
        string line = $"{entry.timestamp}@{entry.content}@{entry._prompt}";
        outputFile.WriteLine(line);
    }
    

}
  }
  public void Load() {
    string filename;
    Console.Write("What is the filename? ");
    filename = Console.ReadLine() ??""; 
    string[] lines = System.IO.File.ReadAllLines(filename);
    Entry info = new Entry();
    List<Entry> load_list = new List<Entry> {};
    foreach (string line in lines)
    {
        string[] parts = line.Split("@");

        info.timestamp = parts[0];
        info.content = parts[1];
        info._prompt = parts[2];
        load_list.Add(info);
        info.Display();

    }
  }
  public void AddEntry(String prompt) {
    Entry info = new Entry();
    //I have no idea how to make this function work. 
    //I can't think of an work around. 
    string input;
    
    Console.Write("> ");
    input = Console.ReadLine();
                // I have no idea how to add the inputs I gave my best try
    info.content = input;
    main_list.Add(info);
    info._prompt = prompt;
    DateTime timestamp = DateTime.Now;
    string data = timestamp.ToShortDateString();
    info.timestamp = data;
    
    




  }

   
}
class Entry 
{
    public string timestamp;
    public string content;
    public string _prompt;

    public void Display() {
        Console.WriteLine($"Date: {timestamp} - Prompt: {_prompt}");
        Console.WriteLine(content);
    }

}

class Menu 
{
    public List<string> prompts = new List<string>();
// Remember to ask what is this called
    public Menu() {
        prompts.Add("How are you feeling today?");
        prompts.Add("What was the best part of your day?");
        prompts.Add("If you had one thing you could do better today, what would it be?");
        prompts.Add("What are your emotions teaching you?");
        prompts.Add("Who do you help today, and how it felt?");
        prompts.Add("Who was the most interesting person you interacted with today?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
    }
    public void Run() {
        bool loop = true; 
        Journal myJournal = new Journal();
        
        while (loop) {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would like to do? ");
            int prompt = int.Parse(Console.ReadLine() ??"");

            if (prompt == 5) {
                loop = false;  
            }
            else if (prompt == 1) {
                Random random = new Random();
                int promptMessage = random.Next(prompts.Count);
                string prompts_ = prompts[promptMessage];
                Console.WriteLine(prompts_);
                myJournal.AddEntry(prompts_);
            }
            else if (prompt == 2) {
                foreach (var entry in myJournal.main_list) {
                    entry.Display();
                }

            }
            else if (prompt == 3) {  
                myJournal.Load();

            }
            else if (prompt == 4) {
                myJournal.Save();
            }
            else {
                Console.WriteLine("Choice not valid, please try again.");
            }
        }
    }
}

