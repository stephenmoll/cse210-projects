public class Breathing : Overlord {

    // Attributes
    private bool _breatheIn;
    private int _holdTime;

    // Constructors
    public Breathing(int holdTime, bool breatheIn, string activity, string description) 
        : base(activity, description) {
            _breatheIn = breatheIn;
            _holdTime = holdTime;
        }

    // Methods

    public void BreathingActivity() {

        if (_breatheIn) {

            Console.Write("Breathe in... ");
            int holding = _holdTime;

            while (holding > 0) {

                Console.Write(holding);
                Thread.Sleep(1100);
                Console.Write("\b \b");
                holding -= 1;
            }

            _breatheIn = false;

            Console.WriteLine();

        } 
        
        else if (!_breatheIn) {

            Console.Write("Breathe out... ");
            int holding = _holdTime;

            while (holding > 0) {

                Console.Write(holding);
                Thread.Sleep(1100);
                Console.Write("\b \b");
                holding -= 1;
            }

            Console.WriteLine();

            _breatheIn = true;
        }

        else {

            Console.WriteLine("Error, bool neither true nor false");
            _breatheIn = true;
        }

        Console.WriteLine();
    }

}