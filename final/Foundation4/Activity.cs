using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime date;
    protected double durationInMinutes;

    public Activity(DateTime date, double durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance() => 0; 
    public virtual double GetSpeed() => 0; 
    public virtual double GetPace() => 60 / GetSpeed(); 

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy}: {GetType().Name} ({durationInMinutes} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}