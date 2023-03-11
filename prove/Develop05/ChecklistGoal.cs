public class ChecklistGoal : Goal {
    // Attributes
    private bool _isComplete;
    private int _timesToComplete;
    private int _timesComplete;


    // Constructors
    public ChecklistGoal(string title, string desc, int value, bool isComplete, int timesToComplete) 
        : base(title, desc, value) {
        _isComplete = isComplete;
        _timesToComplete = timesToComplete;
    }

    public ChecklistGoal(string line) : base(line) {
        string[] info = line.Split("|");

        _timesComplete = Int32.Parse(info[4]);
        _timesToComplete = Int32.Parse(info[5]);
        _isComplete = bool.Parse(info[6]);
    }

    // Methods

        public override string Serialize()
    {
        string serial = $"ChecklistGoal|{_title}|{_desc}|{_value}|{_timesComplete}|{_timesToComplete}|{_isComplete}";
        return serial;
    }

    public override Goal Deserialize(string line)
    {
        string[] info = line.Split("|");
        Console.WriteLine("This methi=od is running");
        _title = info[1];
        _desc = info[2];
        _value = Int32.Parse(info[3]);
        _timesComplete = Int32.Parse(info[4]);
        _timesToComplete = Int32.Parse(info[5]);
        _isComplete = bool.Parse(info[6]);

        ChecklistGoal checklist = new ChecklistGoal(_title, _desc, _value, _isComplete, _timesToComplete);
        return checklist;

    }

    public override void DisplayGoal()
    {

        if (_isComplete ) {
            Console.Write("[X]");
        }

        else if (!_isComplete) {
            Console.Write("[ ]");
        }
        Console.WriteLine($" {_title} ({_desc}) {_timesComplete}/{_timesToComplete}");
    }

    public override void CompleteGoal() {
        if (_timesComplete < _timesToComplete) {
            _timesComplete += 1;

        }

        if (_timesComplete == _timesToComplete) {
            _isComplete = true;
            Console.WriteLine("Great work! You completed your goal! NOw you get your bonus!");
            _value += _value * 3;
        }
    }



}