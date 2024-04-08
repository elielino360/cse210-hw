public class Running : Activity
{
    private double distanceInMiles;

    public Running(DateTime date, double durationInMinutes, double distanceInMiles)
        : base(date, durationInMinutes)
    {
        this.distanceInMiles = distanceInMiles;
    }

    public override double GetDistance() => distanceInMiles;
    public override double GetSpeed() => (distanceInMiles / durationInMinutes) * 60;
}