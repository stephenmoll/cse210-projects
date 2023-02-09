public class Scripture {
    // Attributes
    private string _reference;
    private string _text;

    // Constructors

    public Scripture(string reference, string text) {
        _reference = reference;
        _text = text;
    }
    // Methods

    public void DisplayScripture() {
        Console.WriteLine($"{_reference} \n{_text}");
    }
    public void HideWord(int randyNum) {

        string[] words = _text.Split(" ");
        int underscoreCount = 0;
        

        // USED FOR HIDING A WORD

        string hiddenWord = words[randyNum];

        int count = hiddenWord.Count();
        char underscore = '_';

        String blank = new String(underscore, count);

        words[randyNum] = blank;

        _text = "";

        foreach (string word in words) {

            _text = _text + word + " ";

        }

        foreach (string word in words) {
            if (word.Contains("_")) {
                underscoreCount += 1;
            }
        }

        if (underscoreCount >= words.Count()) {
            return;
        }
    }

    public List<int> GenerateNumberList() {

        string[] words = _text.Split(" ");
        int num = 0;
        List<int> unusedNums = new List<int>();

        foreach (string word in words) {
            unusedNums.Add(num);
            num += 1;
        } 

        return unusedNums;
    }

    public int GenerateRandomNum(List<int> numlist) {
        string[] words = _text.Split(" ");

        Random rd = new Random();
        int randomNum = rd.Next(0, numlist.Count());
        int randyNum = numlist[randomNum];

        return randyNum;
    }
}