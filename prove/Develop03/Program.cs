using System;

//Extras: scriptures are selected at random each time the program runs

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        string[] scriptures = {
            "D&C:20:77:O God, the Eternal Father, we ask thee in the name of thy Son, Jesus Christ, to bless and sanctify this bread to the souls of all those who partake of it, that they may eat in remembrance of the body of thy Son, and witness unto thee, O God, the Eternal Father, that they are willing to take upon them the name of thy Son, and always remember him and keep his commandments which he has given them; that they may always have his Spirit to be with them. Amen.", 
            "D&C:20:79:O God, the Eternal Father, we ask thee in the name of thy Son, Jesus Christ, to bless and sanctify this wine to the souls of all those who drink of it, that they may do it in remembrance of the blood of thy Son, which was shed for them; that they may witness unto thee, O God, the Eternal Father, that they do always remember him, that they may have his Spirit to be with them. Amen.",
            "2 Nephi:2:25:Adam fell that men might be; and men are, that they might have joy.",
            "Alma:46:12:And it came to pass that he rent his coat; and he took a piece thereof, and wrote upon it— In memory of our God, our religion, and freedom, and our peace, our wives, and our children— and he fastened it upon the end of a pole.",
            "Proverbs:3:5-6:Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding. In all thy ways acknowledge him, and he shall direct thy paths."
            };

        Random rd = new Random();
        int randomNum = rd.Next(0, scriptures.Count());
        string chosen = scriptures[randomNum];
            
        Reference scripture = new Reference(chosen);

        string chapter = scripture.GetChapter();
        string book = scripture.GetBook();
        string verse = scripture.GetVerse();
        string content = scripture.GetContent();

        Word goodScripture = new Word(book, chapter, verse, content);

        string heading = goodScripture.GiveHeading();
        string text = goodScripture.GiveContent();

        Scripture finalScripture = new Scripture(heading, text);
        List<int> unusedNums = finalScripture.GenerateNumberList();
        int count = 1000000;
        
        Console.WriteLine("Welcome to scripture memorizor!");
        Console.WriteLine("Hit 'Enter' to hide a word from the scripture, or type 'quit' to end the program.");

        while (input != "quit" && count != 0) {
            
            finalScripture.DisplayScripture();

            count = unusedNums.Count();

            if (count != 0) {

                int randyNum = finalScripture.GenerateRandomNum(unusedNums);
            
            finalScripture.HideWord(randyNum);

            unusedNums.Remove(randyNum);
            
            input = Console.ReadLine();
            Console.Clear();
            }    
        } 
        Console.WriteLine("Bye! See you again soon!");  
    }
}