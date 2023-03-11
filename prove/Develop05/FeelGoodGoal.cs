// THIS ONE IS TO EXCEED REQUIREMENTS

public class FeelGoodGoal : Goal {
    // Atributes

    // Constructors
    public FeelGoodGoal(string line) : base(line) {}

    public FeelGoodGoal(string title, string desc, int value) : base(title, desc, value) {

    }

    // Methods

    public override void DisplayGoal()
    {
        Console.WriteLine($"[X] {_title} ({_desc})");
    }


}