using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal() : base("", "", 0)
    {
        _isComplete = false;
    }

    public override void RecordEvent()//Will mark goal complete [X] and assign the point value to the total score.
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