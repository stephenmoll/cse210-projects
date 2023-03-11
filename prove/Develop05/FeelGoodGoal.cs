// THIS ONE IS TO EXCEED REQUIREMENTS

public class FeelGoodGoal : Goal {
    // Atributes

    // Constructors
    public FeelGoodGoal(string line) : base(line) {
        string[] info = line.Split("|");
        
        _title = info[1];
        _desc = info[2];
    }

    public FeelGoodGoal(string title, string desc, int value) : base(title, desc, value) {

    }

    // Methods

    public override void DisplayGoal()
    {
        Console.WriteLine($"[X] {_title} ({_desc})");
    }

    public override string Serialize() {
        string info = $"FeelGoodGoal|{_title}|{_desc}";
        return info;
    }


}