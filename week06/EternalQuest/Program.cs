using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager(new List<Goal>());
        goalManager.Start();

        SimpleGoal simpleGoal = new SimpleGoal();

        EternalGoal eternalGoal = new EternalGoal();

        ChecklistGoal checklistGoal = new ChecklistGoal();
    }
}