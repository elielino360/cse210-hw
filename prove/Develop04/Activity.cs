using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int Duration { get; private set; }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! You have completed the activity.");
        Console.WriteLine($"You have completed the {_name} activity for {Duration} seconds.");
    }

    public virtual void Run()
    {
        Console.WriteLine("Running the activity...");
    }

    public void Start()
    {
        DisplayStartingMessage();
        Run();
        DisplayEndingMessage();
    }
}
