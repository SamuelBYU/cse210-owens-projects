using System;

public class EternalGoal : Goal
{
    public EternalGoal() : base("", "", 0)
    {
        
    }

     public override void RecordEvent()//Will NOT mark goal complete [ ] but will assign the point value to the total score.
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}