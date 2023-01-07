using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string grading = "";

        if (grade >= 90)
        {
            grading = "A";
        }
        else if (grade >= 80)
        {
            grading = "B";
        }
        else if (grade >= 70)
        {
            grading = "C";
        }    
        else if (grade >= 60)
        {
            grading = "D";
        }
        else 
        {
            grading = "F";
        }

        Console.WriteLine($"Your grade is: {grading}");
        
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time. ");
        }
    }
}