using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

     public override void RecordEvent()//Will NOT mark goal complete [ ] but will assign the point value to the total score.
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal | {GetName()} | {GetDescription()} | {GetPoints()}";
    }
}