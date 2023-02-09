
public class Reference {
    // Attributes 
    private string _citation;

    // Constructors 

    public Reference(string citation) {
        _citation = citation;    
    }

    // Methods 

    public string GetContent() {
        string[] content = _citation.Split(":");

        return content[3];
    }

    public string GetVerse() {
        string[] verse = _citation.Split(":");

        return verse[2];
    }
    
    public string GetChapter() {
        string[] chapter = _citation.Split(":");

        return chapter[1];
    }

    public string GetBook() {
        string[] book = _citation.Split(":");

        return book[0];
    }
}