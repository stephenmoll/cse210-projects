using System;

class Program
{
  static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();

        int squared = SquareNumber(UserNumber);

        DisplayResult(UserName, squared);

        static void DisplayWelcome()
        {
            Console.WriteLine ("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: "); 
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberEntry = Console.ReadLine();
            int FavNumber = int.Parse(numberEntry);

            return FavNumber;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
    }
}
