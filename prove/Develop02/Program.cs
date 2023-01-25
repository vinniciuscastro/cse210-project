using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
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
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");
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
}
class Entry 
{
    public string timestamp;
    public string content;
    public string prompt;

    public void Display() {
    DateTime timestamp = DateTime.Now;
    string data = timestamp.ToShortDateString();
        Console.WriteLine($"Date: {data} - Prompt: {prompt}");
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
    }
    public void Run() {
        bool loop = true; 

        while (loop) {
            Console.WriteLine("Please select onw of the following choices:");
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
                Console.WriteLine(prompts[promptMessage]);
                Console.Write("What was your grade? ");
                string input = Console.ReadLine();
            }
            else if (prompt == 2) {

            }
            else if (prompt == 3) {

            }
            else if (prompt == 4) {

            }
            else {
                Console.WriteLine("Choice not valid, please try again.");
            }
        }
    }
}