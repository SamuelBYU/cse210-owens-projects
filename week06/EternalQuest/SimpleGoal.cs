using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()//Will mark goal complete [X] and assign the point value to the total score.
    {
       if (!_isComplete)
        {
       _isComplete = true;
            
        }
        GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        
        return $"Simple Goal | {GetName()} | {GetDescription()} | {GetPoints()} {_isComplete}";
    }
}