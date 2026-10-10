using System;
using System.Drawing;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

     public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
     public override void RecordEvent()//Will mark goal complete [X] and assign the point value to the total score. Will also determine the total amount of times the goal has been completed.
     //Could contain bonus points for completing max number of goals such as 3\3.
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()}" + $"(Completed {_amountCompleted}/{_target} times.)";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal | {GetName()} | {GetDescription()} | {_target} | {GetPoints()} | {_bonus} | {_amountCompleted}";
    }
}