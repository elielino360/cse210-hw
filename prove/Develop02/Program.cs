class Program
{
    static void Main(string[] args)
    {
        // Instantiate Journal and PromptGenerator objects
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // my prompts 
        promptGenerator.Prompts.Add("Who was the most interesting person I interacted with today?");
        promptGenerator.Prompts.Add("What was the best part of my day?");
        promptGenerator.Prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator.Prompts.Add("What was the strongest emotion I felt today?");
        promptGenerator.Prompts.Add("If I had one thing I could do over today, what would it be?");

        // Main menu loop
        while (true)
        {
            // user display menu options
            Console.WriteLine("\n1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            // Get user input
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            // Perform action based on user choice
            if (choice == "1")
            {
                // Generate a random prompt and get user's entry
                string prompt = promptGenerator.Prompts[new Random().Next(promptGenerator.Prompts.Count)];
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Entry: ");
                string entryText = Console.ReadLine();
                string date = DateTime.Now.ToString();
                journal.AddEntry(new Entry { Date = date, PromptText = prompt, EntryText = entryText });
            }
            else if (choice == "2")
            {
                // Display all journal entries
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Save journal entries to a file
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == "4")
            {
                // Load journal entries from a file
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully.");
            }
            else if (choice == "5")
            {
                // Exit the program
                break;
            }
            else
            {
                // Invalid choice
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
