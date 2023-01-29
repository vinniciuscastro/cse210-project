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
    
    outputFile.WriteLine(main_list);
    
}
  }
  public void Load() {
    string filename;
    Console.Write("What is the filename? ");
    filename = Console.ReadLine() ??""; 
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
    }
  }
  public void AddEntry() {
    Entry info = new Entry();
    //I have no idea how to make this class work. 
    //I can't think of an work around. 
    string input;
    Console.Write("> ");
    input = Console.ReadLine();
                // I have no idea how to add the inputs I gave my best try
    info.content = input;
    main_list.Add(info);

   
  }

    internal void AddEntry(string input)
    {
        throw new NotImplementedException();
    }
}
class Entry 
{
    public string timestamp;
    public string content;
    public string _prompt;

    public void Display() {
    DateTime timestamp = DateTime.Now;
    string data = timestamp.ToShortDateString();
        Console.WriteLine($"Date: {data} - Prompt: {_prompt}");
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
        prompts.Add("What are you emotions teaching you?");
        prompts.Add("Who do you help today, and how it felt?");
        prompts.Add("Who was the most interesting person you interacted with today?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
    }
    public void Run() {
        bool loop = true; 
        Journal myJournal = new Journal();
        Entry info = new Entry();
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
                Menu menu = new Menu();
                Random random = new Random();
                int promptMessage = random.Next(prompts.Count);
                string prompts_ = prompts[promptMessage];
                Console.WriteLine(prompts_);
                info._prompt = prompts_;
                myJournal.main_list.Add(info);
                myJournal.AddEntry();

                

                
                
                
            }
            else if (prompt == 2) {
                Entry content = new Entry();
                content.Display(); 

            }
            else if (prompt == 3) {
                Journal loadFile = new Journal();
                loadFile.Load();

            }
            else if (prompt == 4) {
                Journal save = new Journal();
                save.Save();
            }
            else {
                Console.WriteLine("Choice not valid, please try again.");
            }
        }
    }
}