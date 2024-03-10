class Entry
{
    public string Date;
    public string PromptText;
    public string EntryText;

    public void display()
    {
        Console.Write($"Date: {Date}");
        Console.WriteLine($"Prompt text: {PromptText}");
        Console.WriteLine($"Entry Text: {EntryText}");
    }

}
