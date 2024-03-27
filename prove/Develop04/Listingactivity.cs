using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public List<string> items = new List<string>();
    

    public override void Run()
    {
        var prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Starting shortly...");
        Thread.Sleep(Duration);
    
         while (true)
        {
            string input = Console.ReadLine(); 
           

            if (input.ToLower() == "done")
            

            items.Add(input); 
            
            _count++;

            Console.WriteLine($"You listed {_count} items.");

        }

        


       
        
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }


    public void GetListFromUser()
    {
    
    }
}

internal class Duration
{
}