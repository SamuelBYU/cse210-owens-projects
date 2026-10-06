using System;

using static System.Math;
public class Circle : Shapes
{
    private double _radius;

    
    public Circle(double radius) : base("Green")
    {
        _radius = radius;
    }
    public override double AreaOfShape()
    {
        double circleArea = _radius * _radius * PI;
        return circleArea;
    }

}