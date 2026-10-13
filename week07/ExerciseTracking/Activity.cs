using System;
using System.Runtime.InteropServices;

public abstract class Activity
{
    protected int _date;

    protected double _duration;//Length of the activity in minutes.

    public Activity(int date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }
   

    public virtual double CalculateSpeed()
    {
        return 0;
    }
   

    public abstract double CalculatePace();
    
    public abstract string Summary();

    //The summary needs to look something like this:
    //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile


}