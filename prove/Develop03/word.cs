
public class Word {
    // Attributes 
    private string _book;
    private string _chapter;
    private string _verse;
    private string _content;

    // Constructors 

    public Word(string book, string chapter, string verse, string content){

        _book = book;
        _chapter = chapter;
        _verse = verse;
        _content = content;
    }

    // Methods

    public string GiveContent() {
        return _content;
    }

    public string GiveHeading() {
        string heading = $"{_book} {_chapter}; {_verse}:";
        return heading;
    }
}