using System;

using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    
    public GoalManager(List<Goal> goals)
    {
        _score = 0;
        _goals = goals;
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
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
                SimpleGoal simpleGoal = new SimpleGoal();
                Console.WriteLine("The types of goals are:\n1. Simple Goals\n2. Eternal Goals\n3. Checklist Goals");
                Console.Write("Which type of goal would you like to create?: ");
                string userResponse2 = Console.ReadLine();
                int choice2 = int.Parse(userResponse2);
                if (choice2 == 1)
                {
                    simpleGoal.RecordEvent();
                }
                else if (choice2 == 2)
                {
                    
                }
                else if (choice2 == 3)
                {
                    
                }
            }
            else if (choice1 == 2)
            {
                
            }
            else if (choice1 == 3)
            {
                
            }
            else if (choice1 == 4)
            {
                
            }
            else if (choice1 == 5)
            {
                
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


        }
    }

    public void DisplayPlayerInformation()
    {

    }

    public void ListGoalNames()
    {
        
    }

    public void ListGoalDetails()
    {
        
    }

    public void CreateGoal()
    {
        
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals()
    {
        
    }

    public void LoadGoals()
    {
        
    }
}