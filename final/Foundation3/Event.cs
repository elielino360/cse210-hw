public abstract class Event
{
    protected string title;
    protected string description;
    protected string time;
    protected DateTime eventDate;
    protected Address address;

    public Event(string title, string description, DateTime eventDate, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.eventDate = eventDate;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails() => $"{title}, {description}, {eventDate.ToShortDateString()}, {time}, {address}";

    public virtual string GetFullDetails() => GetStandardDetails();

    public virtual string GetShortDescription() => $"{title}, {eventDate.ToShortDateString()}";
}
