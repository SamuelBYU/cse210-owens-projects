using System;
using System.Runtime.InteropServices;

public abstract class Activity
{
    private int _date;

    private int _duration;//Length of the activity in minutes.

    public Activity(int date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract int CalculateDistance();
   

    public abstract int CalculateSpeed();
   

    public abstract int CalculatePace();
    
    public abstract void Summary();




}