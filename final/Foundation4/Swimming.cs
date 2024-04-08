public class Swimming : Activity
{
    private int numberOfLaps;
    private const double LapLengthInMiles = 50 / 1000 * 0.62; 

    public Swimming(DateTime date, double durationInMinutes, int numberOfLaps)
        : base(date, durationInMinutes)
    {
        this.numberOfLaps = numberOfLaps;
    }

    public override double GetDistance() => numberOfLaps * LapLengthInMiles;
    public override double GetSpeed() => GetDistance() / (durationInMinutes / 60);
}
