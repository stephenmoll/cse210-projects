public class Overlord {
    // Attributes
    private string _activity;
    private string _description;
    private int _duration;

    // Constructors
    public Overlord(string activity, string description) {

        _activity = activity;
        _description = description;

    }

    // Methods

    public void StartPhrase() {
        Console.WriteLine($"Allow us to begin the {_activity} activity.");
    }

    public void EndPhrase() {
        Console.WriteLine($"Well done. We have completed another {_duration} seconds of the {_activity} activity.");
    }

    public void DisplayDescription() {
        Console.WriteLine(_description);
    }

    public int GetDuration() {
        Console.WriteLine("How long, in seconds, would you like for this session? : ");
        string num = Console.ReadLine();
        _duration = Int32.Parse(num);
        return _duration;
    }

    public System.DateTime GetFutureTime(int seconds) {
        DateTime time = DateTime.Now;

        DateTime futureTime = time.AddSeconds(seconds);

        return futureTime;

    }

    public void ShowWaitingAnimation() {
        // Code here
        int count = 0;
        while (count < 3) {
            
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            count += 1;
        }
        Console.WriteLine();
       
    }
}