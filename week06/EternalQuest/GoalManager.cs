using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals;

    private int _score;

    
    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInformation();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Please select an option from the menu: ");
            string userResponse1 = Console.ReadLine();
            int choice1 = int.Parse(userResponse1);

            if (choice1 == 1)
            {
                CreateGoal();
            }
            else if (choice1 == 2)
            {
                ListGoalDetails();
            }
            else if (choice1 == 3)
            {
                SaveGoals();
            }
            else if (choice1 == 4)
            {
                LoadGoals();
            }
            else if (choice1 == 5)
            {
                RecordEvent();
            }
            else if (choice1 == 6)
            {
                Console.WriteLine("Have a great day!");
                break;
            }
            else
            {
                Console.WriteLine("Please select an option 1-6. ");
            }

            if (choice1 != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter To Continue To Menu...");
                Console.ReadLine();
            }
        }
    }

    public void DisplayPlayerInformation()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have not created any goals yet");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have not created any goals yet.");
            return;
        }
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("Which goal would you like to create? ");
        string userResponse = Console.ReadLine();
        int goalType = int.Parse(userResponse);

        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        
        

        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        

        Console.Write("What is the amount of points associated with this goal?: ");
        string simpleResponse = Console.ReadLine();
        int points = int.Parse(simpleResponse);

        if (goalType == 1)
        {
            Goal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == 2)
        {
            Goal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == 3)
        {
            Console.WriteLine("What is the target goal?: ");
            string target = Console.ReadLine();
            int targetAmount = int.Parse(target);

            Console.WriteLine("What is the bonus points?: ");
            string bonus = Console.ReadLine();
            int bonusPoints = int.Parse(bonus);

            Goal newGoal = new ChecklistGoal(name, description, points, targetAmount, bonusPoints);
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("INVALID GOAL TYPE.");
            return;
        }
        Console.WriteLine("Goal created succesfully!");

    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record");
            return;
        }

        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        string userResponse = Console.ReadLine();
        int accomplish = int.Parse(userResponse);

        if (accomplish < 1 || accomplish > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selectedGoal = _goals[accomplish - 1];

        if (selectedGoal.IsComplete())
        {
            Console.WriteLine("This goal is already complete.");
        }
        else
        {
            selectedGoal.RecordEvent();

            _score = _score + selectedGoal.GetPoints();

            if (selectedGoal is ChecklistGoal)
            {
                ChecklistGoal checklist = (ChecklistGoal)selectedGoal;

                if (checklist.IsComplete())
                {
                    _score = _score + checklist.GetBonus();
                    Console.WriteLine("You earned bonus points!");
                }
            }
            Console.WriteLine("Event recorded successfully.");
        }

        
    }

    public void SaveGoals()
    {
        Console.WriteLine("What file would you like to save this to?: ");
        string saveFile = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goal saved successfully.");
    }

    public void LoadGoals()
    {
        Console.WriteLine("What goal file would you like to load?: ");
        string loadFile = Console.ReadLine();

        if (!File.Exists(loadFile))
        {
            Console.WriteLine("This file does not exist.");
            return;
        }

        string [] lines = System.IO.File.ReadAllLines(loadFile);

        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
            return;
        }

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "Simple Goal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (parts[0] == "Eternal Goal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (parts[0] == "Checklist Goal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully");
    }
}