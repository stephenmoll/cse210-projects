public class Listing : Overlord{

    // Attributes
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        };

    // Used in exceeding requirements
    private List<string> _entries = new List<string>();
    
    // Constructors
    public Listing(string activity, string description)
        : base(activity, description) {    
            // Getters and setters not needed
        }
    
    //Methods
    public string ShowPrompt() {
        Random _rd = new Random();
        int randomNum = _rd.Next(0, _prompts.Count());
        string prompt = _prompts[randomNum];

        Console.WriteLine($"--- {prompt} ---");

        // Used to exceed requirements
        return prompt;
    }
    public void DisplayEntryCount() {
        int entryCount = _entries.Count();
        Console.WriteLine($"Brilliant! We wrote {entryCount} entries this session!");
    }

    public string GetEntry() {
        Console.Write("> ");
        string entry = Console.ReadLine();

        _entries.Add(entry);

        return entry;
    }
}