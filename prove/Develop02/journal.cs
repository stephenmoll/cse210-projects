using System.IO;

public class Journal {

     

    //member variables
    public List<string> _prompts = new List<string>();

    public List<string> _pages = new List<string>();

    public string _filename = ""; 

    public List<string> _dates = new List<string>();


    //call class
    public Journal(){}

    //methods

    public void DisplayEntries(){
        for (int i = 0; i <= _pages.Count() - 1; i++) {
            Console.Write($"\nDate: {_dates[i]} - ");
            Console.WriteLine($"Prompt: {_prompts[i]}");
            Console.WriteLine($"{_pages[i]}");
        }
    }

    public void Save(){
        Console.Write("What .txt file would you like to save these entries to?: ");
        _filename = Console.ReadLine();
        Console.WriteLine();

        using (StreamWriter journalContent = new StreamWriter(_filename)) {

            for(int i = 0; i <= _pages.Count() - 1; i++){
                journalContent.Write(_dates[i]);
                journalContent.Write("|");
                journalContent.Write(_prompts[i]);
                journalContent.Write("|");
                journalContent.WriteLine(_pages[i]);

            }

        }

        
    }

    public void Load(){
        Console.Write("Please enter the name of the .txt file you would like to load: ");
        _filename = Console.ReadLine();
        string[] content = System.IO.File.ReadAllLines(_filename);

        foreach (string line in content){
            string[] parts = line.Split("|");

            string loadDate = parts[0];
            string loadPrompt = parts[1];
            string loadContent = parts[2];

            _dates.Add(loadDate);
            _prompts.Add(loadPrompt);
            _pages.Add(loadContent);
        }


    }

}