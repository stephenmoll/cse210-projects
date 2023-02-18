public class MathAssignment : Assignment {
    // Attributes 
    private string _textbookSection;
    private string _problems;

    // Constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _textbookSection = textbookSection;
        _problems = problems;

    }

    // Methods

    public string GetHomeworkList() {
        string homeworkList = $"Section: {_textbookSection}, Problems: {_problems}";
        return homeworkList;
    }

}