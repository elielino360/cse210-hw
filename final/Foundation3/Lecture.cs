public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime eventDate, string time, Address address, string speaker, int capacity)
        : base(title, description, eventDate, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails() => $"{base.GetFullDetails()}, Speaker: {speaker}, Capacity: {capacity}";
}
