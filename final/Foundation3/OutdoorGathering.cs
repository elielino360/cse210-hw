public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime eventDate, string time, Address address, string weatherForecast)
        : base(title, description, eventDate, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails() => $"{base.GetFullDetails()}, Weather: {weatherForecast}";
}
