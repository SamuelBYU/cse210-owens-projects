using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus) : base("", "", 0)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

     public override void RecordEvent()//Will mark goal complete [X] and assign the point value to the total score. Will also determine the total amount of times the goal has been completed.
     //Could contain bonus points for completing max number of goals such as 3\3.
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}