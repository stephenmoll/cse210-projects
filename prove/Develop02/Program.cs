using System;


class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        Journal write = new Journal();
        Entry content = new Entry();
        List<string> pages = new List<string>();
        List<string> prompts = new List<string>();
        List<string> dates = new List<string>();


        Console.WriteLine("HI!");
        Console.WriteLine("I'm Citree! I'll be your Journal Keeper for this writing session!");

        while (answer != "5") {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit \n");
            Console.Write("Select an option: ");
            answer = Console.ReadLine();

            if (answer == "1") {
                //code here

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString(); 
                dates.Add(dateText);

                content.GivePrompt();
                string prompt = content._prompt;
                prompts.Add(prompt);


                content.WriteEntry();
                string page = content._entry;
                pages.Add(page);

                Console.WriteLine("\nThat was a lovely entry!");


            }

            else if (answer == "2") {
                
                write._dates = dates;
                write._prompts = prompts;
                write._pages = pages;
                write.DisplayEntries();
                Console.WriteLine("\nYup, those are some deep entries right there.");

            }

            else if (answer == "3") {

                Console.WriteLine("Loading deep dark secrets... Kidding XD");

                pages = new List<string>();
                prompts = new List<string>();
                dates = new List<string>();

                write.Load();

                pages = write._pages;
                prompts = write._prompts;
                dates = write._dates;
                
            }

            else if (answer == "4") {

                Console.WriteLine("Saving data...");

                write._dates = dates;
                write._prompts = prompts;
                write._pages = pages;

                write.Save();

                Console.WriteLine("Data stored successfully!");
                
            }
            else if (answer == "5") {
                
            }
        }
    }
}