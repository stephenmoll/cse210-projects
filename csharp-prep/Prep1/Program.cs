using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        String firstname = Console.ReadLine();

        Console.Write("What is your Last name? ");
        String lastname = Console.ReadLine();
    
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}