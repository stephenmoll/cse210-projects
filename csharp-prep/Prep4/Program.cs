using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
        List<int> numbers = new List<int>();

     
        Console.WriteLine($"\r\nPlease enter a number (one at a time) to added it to your number list. \r\nWhen finished, please enter a 0 to continue.");
        int numberEntry = -1;
        while (numberEntry !=0)
        {
            Console.Write("Number: "); string EnteredNumber = Console.ReadLine();
            numberEntry = int.Parse(EnteredNumber);

            if (numberEntry != 0)
            {
                numbers.Add(numberEntry);
            }
        }

        
        int sum = 0;
        foreach (int number in numbers)    
        {
            sum += number;
        }
        Console.WriteLine ($"\r\nThe sum of the numbers is: {sum}");

       
        float avg = ((float)sum) /numbers.Count;
        Console.WriteLine($"The average of the numbers is: {avg}");

     
        Console.WriteLine($"The highest number in the list is: " + numbers.Max());

        Console.WriteLine($"The lowest number in the list is: " + numbers.Min());
    }
}