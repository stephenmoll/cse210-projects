using System;

class Program
{
    static void Main(string[] args)
        {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        //int number = 4;
        int guess = -5;
        while (number != guess)  
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine ("Too low. Please guess something that is HIGHER.");
            }
            else if (number < guess)
            {
                Console.WriteLine ("Too high. Please guess another number that is LOWER.");
            }
            else
            {
                Console.WriteLine ($"Well done! Number {number} is indeed the magic number!");    
            }
        }
    }
}