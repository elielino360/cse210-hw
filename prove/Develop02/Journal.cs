class Journal
{
    public List<Entry> Entries;


    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.PromptText}");
            Console.WriteLine($"Entry: {entry.EntryText}\n");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.PromptText}");
                writer.WriteLine($"Entry: {entry.EntryText}");
                writer.WriteLine(new string('-', 20));
            }
        }
    }

    public void LoadFromFile(string file)
    {
        Entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string date = line.Substring(6); 
                string promptText = reader.ReadLine().Substring(8);
                string entryText = reader.ReadLine().Substring(7);
                Entries.Add(new Entry { Date = date, PromptText = promptText, EntryText = entryText });
                reader.ReadLine(); 
            }
        }
    }
}
