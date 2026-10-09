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
        Console.Write("What is the name of your goal?: ");
        string simpleResponse1 = Console.ReadLine();
        
        

        Console.Write("What is a short description of it?: ");
        Console.ReadLine();
        

        Console.Write("What is the amount of points associated with this goal?: ");
        string simpleResponse = Console.ReadLine();
        int simpleChoice = int.Parse(simpleResponse);
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