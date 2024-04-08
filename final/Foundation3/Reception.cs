public class Reception : Event
{
    private string emailForRSVP;

    public Reception(string title, string description, DateTime eventDate, string time, Address address, string emailForRSVP)
        : base(title, description, eventDate, time, address)
    {
        this.emailForRSVP = emailForRSVP;
    }

    public override string GetFullDetails() => $"{base.GetFullDetails()}, RSVP at: {emailForRSVP}";
}
