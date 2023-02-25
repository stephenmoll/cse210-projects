public class Reflecting : Overlord{
    // Attributes 
    private string[] _prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private string[] _secondaryPrompts = {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    };
    

    // Constructors
    public Reflecting(string activity, string description) 
        : base(activity, description) {
            // Did not need any getters or setters
        }

    // Methods
    public void DisplayPrompt() {
        Random _rd = new Random();
        int randomNum = _rd.Next(0, 6);

        Console.WriteLine($"--- {_prompts[randomNum]} ---");
        
    }

    public void DisplaySecondary() {
        Random _rd = new Random();
        int randomNum = _rd.Next(0, 6);

        Console.WriteLine($"> {_secondaryPrompts[randomNum]}");
    }

   

    
}