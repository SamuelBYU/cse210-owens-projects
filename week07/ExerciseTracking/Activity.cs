using System;
using System.Runtime.InteropServices;

public abstract class Activity
{
    protected int _date;

    protected int _duration;//Length of the activity in minutes.

    public Activity(int date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract int CalculateDistance();
   

    public abstract int CalculateSpeed();
   

    public abstract int CalculatePace();
    
    public abstract string Summary();




}