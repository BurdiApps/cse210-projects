using System;

// Circle class inherits from Shape
public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea to calculate circle area
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
