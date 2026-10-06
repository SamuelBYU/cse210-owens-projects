using System;

public class Square : Shapes
{
    
    private double _side;

    public Square(double side) : base("Red")
    {
        _side = side;
    }
    
    public override double AreaOfShape()
    {
        return _side * _side;
    }
}