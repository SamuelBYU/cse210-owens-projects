using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, int date, int duration) : base(date, duration)
    {
        _laps = laps;
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
}