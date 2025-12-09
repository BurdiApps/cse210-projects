using System;

// Base class for all activities
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected int Minutes => _minutes;
    protected DateTime Date => _date;

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method - can be overridden but has default implementation
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivityType()} ({_minutes} min) - Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }

    protected abstract string GetActivityType();
}
