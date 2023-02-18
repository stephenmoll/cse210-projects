public class Assignment {
    // Attributes 
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string name, string topic) {

        _studentName = name;
        _topic = topic;

    }

    // Methods

    public string GetName() {
        return _studentName;
    }

    public string GetTopic() {
        return _topic;
    }
    
    public string GetSummary() {
        string summary = $"{_studentName}, {_topic}";
        return summary;
    }

}