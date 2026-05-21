using System;
class Program
{

    static void Main(string[] args)
    {
        // Creativity / Exceeds Requirements:
        // Instead of hiding words that may already be hidden, my program only hides words (its more simple for me now) that are still visible. This makes the memorization process smoother and avoidswasting turns on words that are already hidden.

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";

        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
            
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}