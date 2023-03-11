using System;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();
        string[] goalTypes = {"Simple", "Eternal", "Checklist", "Feel Good"};
        string [] options = {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
        int total = 0;
        string choice = "";

        // Open a while loop that runs as long as the user doesn't choose to quit
        while (choice != "6") {

            // Display current score
            Console.WriteLine();
            Console.WriteLine($"Your current score is: {total}");
            Console.WriteLine();

            // Display all options
            Console.WriteLine("Menu Options");
            for (int i = 0; i < options.Count(); i ++) {
                Console.WriteLine($"  {i+1}. {options[i]}");
            }

            // Allow the user to choose an option
            Console.Write("What will you choose? ");
            choice = Console.ReadLine();
            Console.WriteLine();

            // If the user chooses the create goal option
            if (choice == "1") {

                Console.WriteLine("Here are the goal types you can choose from:");

                // Display the kinds of goals they can make
                for(int i = 0; i < goalTypes.Count(); i ++) {
                    Console.WriteLine($"   {i+1}. {goalTypes[i]}");
                }

                // Allow them to choose a goal type
                Console.Write("What number will you choose?: ");
                choice = Console.ReadLine();
                Console.WriteLine();

                // If they choose the simple goal option
                if (choice == "1") {
                    
                    // Get the data to create a new simple goal
                    
                    Console.WriteLine("What is the name of your goal?");
                    string goalName = Console.ReadLine();
                    

                    Console.WriteLine("Give a short description of your goal: ");
                    string goalDesc = Console.ReadLine();
                    

                    Console.WriteLine("How many points is this goal worth? ");
                    int pointValue = Int32.Parse(Console.ReadLine());


                    // Chuck that sortedrmation into our SimpleGoal object
                    SimpleGoal simple = new SimpleGoal(goalName, goalDesc, pointValue, false);
                    // Add the goal to the list of goals
                    goals.Add(simple);

                }

                else if (choice == "2") {
                    // Get the data to create a new eternal goal
                    
                    Console.WriteLine("What is the name of your goal?");
                    string goalName = Console.ReadLine();
                    

                    Console.WriteLine("Give a short description of your goal: ");
                    string goalDesc = Console.ReadLine();
                    

                    Console.WriteLine("How many points is this goal worth? ");
                    int pointValue = Int32.Parse(Console.ReadLine());


                    // Chuck that sortedrmation into our EternalGoal object
                    EternalGoal eternal = new EternalGoal(goalName, goalDesc, pointValue);
                    // Add the goal to the list of goals
                    goals.Add(eternal);
                    
                }

                else if (choice == "3") {
                    Console.WriteLine("What is the name of your goal?");
                    string goalName = Console.ReadLine();
                    

                    Console.WriteLine("Give a short description of your goal: ");
                    string goalDesc = Console.ReadLine();
                    

                    Console.WriteLine("How many points is this goal worth? ");
                    int pointValue = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How manytimes should you complete this goal before it is finished?");
                    int timesToComplete = Int32.Parse(Console.ReadLine());


                    ChecklistGoal checklist = new ChecklistGoal(goalName, goalDesc, pointValue, false, timesToComplete);
                    goals.Add(checklist);

                }

                // THIS PART IS TO EXCEED ERQUIREMENTS
                else if (choice == "4") {
                    Console.WriteLine("Welcome to your new feel good goal! \nHow much would you like this goal to be worth?");
                    int pointValue = Int32.Parse(Console.ReadLine());

                    FeelGoodGoal feelGood = new FeelGoodGoal("Feel Good!", "This goal literally just gives you more points", pointValue);

                    total += feelGood.GetValue();

                    goals.Add(feelGood);

                }
            }

            // If the user chooses to view the list of goals
            else if (choice == "2") {


                // Emphasise that this is the list of goals
                Console.WriteLine("Here is your list of goals: ");
                Console.WriteLine();

                // Display every goal in the list
                foreach (Goal item in goals) {
                    item.DisplayGoal();
                }

                Console.WriteLine();
                // Pause here to let the user review their list of goals
                Console.WriteLine("Hit enter to continue... ");
                Console.ReadLine();
            }

            // If the user chooses to save their goals
            else if (choice == "3") {

                // Get the filename to save to
                Console.WriteLine("What file would you like to save to?");
                string filename = Console.ReadLine();

                // open / create the new file
                using (StreamWriter saveFile = new StreamWriter(filename)) {
                    
                    // Save the total score first
                    saveFile.WriteLine(total);
                    
                    // for each goal in the goal list
                    foreach (Goal item in goals) {
                        // Serialize the goal sortedrmation
                        string line = item.Serialize();
                        // Write the sortedrmation to the save file
                        saveFile.WriteLine(line);
                    }  
                }
            }

            //If the user chooses to load their goals from a file
            else if (choice == "4") {

                Console.WriteLine("What file would you like to load from?");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);
                
                total = Int32.Parse(lines[0]);

                foreach(string line in lines) {

                    string[] info = line.Split("|");

                    if (line != lines[0]) {

                        if (info[0] == "SimpleGoal") {
                            SimpleGoal simple = new SimpleGoal(line);
                            goals.Add(simple);
                        }

                        else if (info[0] == "EternalGoal") {
                            EternalGoal eternal = new EternalGoal(line);
                            goals.Add(eternal);
                        }

                        else if (info[0] == "ChecklistGoal") {
                            ChecklistGoal checklist = new ChecklistGoal(line);
                            goals.Add(checklist);
                        }

                        else if (info[0] == "FeelGoodGoal") {
                            FeelGoodGoal feelgood = new FeelGoodGoal(line);
                            goals.Add(feelgood);

                        }
                    }

                }

            }
            
            // If the user chooses to complete a goal
            else if (choice == "5") {

                // Set count variable to 1
                int count = 1;

                // Emphasise that this is the list of their goals
                Console.WriteLine("Here is your list of goals: ");
                Console.WriteLine();

                // Display every goal in the list along with an index 
                // which the user can enter to select that goal
                foreach (Goal line in goals) {
                    Console.Write($"{count}. ");
                    line.DisplayGoal();
                    count += 1;
                }

                Console.WriteLine();
                Console.WriteLine("Which goal would you like to complete? ");
                // Take an input from the user and convert it into an int, 
                // and subtract 1 so that it uses the correct value
                int chosen = Int32.Parse(Console.ReadLine()) - 1;

                // Save the goal the user has chosen into a variable
                Goal chosenGoal = goals[chosen];
                total += chosenGoal.GetValue();

                // Complete the chosen goal
                chosenGoal.CompleteGoal();

                // Yay! They completed a goal!
                Console.WriteLine("Goal complete!");

            }

            // If the user chooses to quit
            else if (choice == "6") {

                // The user has chosen the terminate the program. Let them know.
                Console.WriteLine("Thank you for using the goal setting program. Hit enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}