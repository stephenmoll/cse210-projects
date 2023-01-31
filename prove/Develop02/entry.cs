public class Entry{
    //attributes 

    Random _rd = new Random();
    public string _entry = "";
    public string[] _prompts = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is something that happened today that I am grateful for?"};
    public string _prompt = "";

    public Entry(){}

    //methods
    public void WriteEntry(){
        Console.Write("> ");
        _entry = Console.ReadLine();

    }

    public void GivePrompt(){
        int randomNum = _rd.Next(0, 6);
        _prompt = _prompts[randomNum];

        Console.WriteLine($"\n> {_prompt}");
    }

}
