using System;

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
            string userResponse = Console.ReadLine();
            int choice = int.Parse(userResponse);

            if (choice == 1)
            {
                
            }
            else if (choice == 2)
            {
                
            }
            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
            {
                
            }
            else if (choice == 6)
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