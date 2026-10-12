using System;

public class Running : Activity
{
    private int _distance;

    public Running(int distance, int date, int duration) : base(date, duration)
    {
        _distance = distance;
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

    public override string Summary()
    {
        return "";
    }
}