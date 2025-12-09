using System;

// Running activity - tracks distance
public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        return (_distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per km) = minutes / distance
        return Minutes / _distance;
    }

    protected override string GetActivityType()
    {
        return "Running";
    }
}
