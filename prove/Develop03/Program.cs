using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a scripture
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Display the complete scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Prompt the user to press enter or type quit
        while (true)
        {
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide a few random words and display the updated scripture
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            
            // If all words are hidden, break the loop
            if (scripture.IsCompletelyHidden())
                break;
        }
    }
}