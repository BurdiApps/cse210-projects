using System;

// Square class inherits from Shape
public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea to calculate square area
    public override double GetArea()
    {
        return _side * _side;
    }
}
