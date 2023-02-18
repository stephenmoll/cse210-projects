public class WritingAssignment : Assignment {
    // Attributes
    private string _title;

    // Constructors 
    public WritingAssignment(string name, string topic, string title) 
        : base(name, topic) {
        _title = title;
    }
    // Methods

    public string GetWritingInformation()
    {
        string studentName = GetName();

        return $"{_title} by {studentName}";
    }


}