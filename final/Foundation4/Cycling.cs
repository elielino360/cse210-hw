public class Cycling : Activity
{
    private double speedInMPH;

    public Cycling(DateTime date, double durationInMinutes, double speedInMPH)
        : base(date, durationInMinutes)
    {
        this.speedInMPH = speedInMPH;
    }

    public override double GetDistance() => (speedInMPH * durationInMinutes) / 60;
    public override double GetSpeed() => speedInMPH;
}