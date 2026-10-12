using System;

public class Cycling : Activity
{
    private int _speed;

    public Cycling(int speed, int date, int duration) : base(date, duration)
    {
        _speed = speed;
    }

    public override int CalculateDistance()
    {
        return 0;
    }
   

    public override int CalculateSpeed()
    {
        return 0;
    }
   

    public override int CalculatePace()
    {
        return 0;
    }

    public virtual void Summary();
}