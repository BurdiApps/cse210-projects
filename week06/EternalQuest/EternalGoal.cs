using System;

// Goal that is never complete and can be recorded many times
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Eternal goals are never complete, just award points
        return _points;
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}
