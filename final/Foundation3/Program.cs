class Program
{
    static void Main()
    {
        var lectureEvent = new Lecture("Pep Talk", "A lecture on Wole soyinka", DateTime.Now.AddDays(30), "2 PM", new Address("123 Elm St", "Springfield", "Lagos", "Nigeria"), "Dr. Wole Soyinka ", 100);
        var receptionEvent = new Reception("Gallery Opening", "An evening of art and conversation", DateTime.Now.AddDays(45), "7 PM", new Address("456 Main St", "Ajah", "Lagos", "Nigeria"), "art@gallery.com");
        var outdoorEvent = new OutdoorGathering("Community Picnic", "A day out in the sun with friends and family", DateTime.Now.AddDays(60), "11 AM", new Address("789 Park Ave", "Lekki", "Lagos", "Nigeria"), "Sunny with a chance of showers");

        Console.WriteLine("Event Marketing Material:\n");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine("\n-----------------------------------\n");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine("\n-----------------------------------\n");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}