using System;

while (true) 
        {
    Console.WriteLine("\nWelcome to the Activity App");
    Console.WriteLine("1. Breathing Activity");
    Console.WriteLine("2. Listing Activity");
    Console.WriteLine("3. Reflecting Activity");
    Console.WriteLine("4. Quit");
    Console.WriteLine("Please select an activity (1-4):");

    var selection = Console.ReadLine();
    if (selection == "4")
    {
        Console.WriteLine("Thank you for using the Activity App. Goodbye!");
        break;
    }

    Activity activity = null;

    switch (selection)
    {
        case "1":
            activity = new BreathingActivity();
            break;
        case "2":
            activity = new ListingActivity();
            break;
        case "3":
            activity = new ReflectingActivity();
            break;
        default:
            Console.WriteLine("Invalid selection. Please select a valid option.");
            continue;
    }


    activity.Start();
}
