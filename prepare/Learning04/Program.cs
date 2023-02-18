using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Red", "Software Engineering");

        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Red", "Math for Dummies", "3.14159", "10-15");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Red", "Writing for Smarties", "The Tale of the Geobots");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
        Console.WriteLine();


    }
}