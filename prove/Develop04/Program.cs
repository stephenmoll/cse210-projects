using System;

class Program
{
    static void Main(string[] args)
    {


        string[] descriptions = new string[] {
            "This activity will help you relax by slowly walking you through your breathing in and out. Clear your mind and focus on your breathing.",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.",
        };

        string[] options = new string[] {
            "1. Breathing",
            "2. Reflecting",
            "3. Listing",
            "4. Quit"

        };

        Overlord neuteral = new Overlord("blank", "blank");

        string choice = "0";

        Console.WriteLine("Welcome to the Mindfulness Program");

        while (choice != "4") {


            neuteral.ShowWaitingAnimation();


            foreach (string option in options) {
                Console.WriteLine(option);
                }

            Console.Write("Which number option would you like? : ");
            choice = Console.ReadLine();

            if (choice == "1") {

                Console.Clear();

                Breathing breathing = new Breathing(6, true, "Breathing", descriptions[0]);

                breathing.StartPhrase();
                breathing.DisplayDescription();
                Console.WriteLine();
                int duration = breathing.GetDuration();
                DateTime currentTime = DateTime.Now;
                DateTime futureTime = breathing.GetFutureTime(duration);
                Console.WriteLine();

                Console.WriteLine("Get Ready");
                breathing.ShowWaitingAnimation();

                while (currentTime <= futureTime) {
                    
                    breathing.BreathingActivity();
                    
                    currentTime = DateTime.Now;
                }

                Console.WriteLine();
                breathing.EndPhrase();
                
            }

            else if (choice == "2") {

                Console.Clear();

                // Code here
                Reflecting reflecting = new Reflecting("Reflection", descriptions[1]);

                reflecting.StartPhrase();
                reflecting.DisplayDescription();
                Console.WriteLine();
                int duration = reflecting.GetDuration();
                Console.WriteLine();

                DateTime currentTime = DateTime.Now;
                DateTime futureTime = reflecting.GetFutureTime(duration);

                reflecting.DisplayPrompt();
                reflecting.ShowWaitingAnimation();


                while (currentTime <= futureTime) {

                    reflecting.DisplaySecondary();
                    reflecting.ShowWaitingAnimation();
                    currentTime = DateTime.Now;

                }


                Console.WriteLine();
                reflecting.EndPhrase();


            }

            else if (choice == "3") {
                Console.Clear();

                Listing listing = new Listing("Listing", descriptions[2]);


                listing.StartPhrase();
                listing.DisplayDescription();
                Console.WriteLine();

                int duration = listing.GetDuration();
                Console.WriteLine();

                DateTime currentTime = DateTime.Now;
                DateTime futureTime = listing.GetFutureTime(duration);

                listing.ShowPrompt();
                listing.ShowWaitingAnimation();

                while (currentTime <= futureTime) {
                    
                    listing.GetEntry();

                    currentTime = DateTime.Now;

                }

                Console.WriteLine();
                listing.DisplayEntryCount();
                Console.WriteLine();
                listing.EndPhrase();
            }

            else if (choice == "4") {
                break;
            }
            else {
                Console.WriteLine($"Failed to run with choice '{choice}', inappropriate value input");
            }
        }
  
    }
}