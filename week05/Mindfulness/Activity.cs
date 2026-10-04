using System;



public class Activity
{
    private string _name = "";
    private string _description = "";
    private int _duration;

    

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    protected void SetName(string name)
    {
        _name = name;
    }

    protected void SetDescription(string description)
    {
        _description = description;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"---{_name}---");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("How many seconds would you like to do this activity for?: ");
        string amountOfTime = Console.ReadLine();
        _duration = int.Parse(amountOfTime);

        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");

        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");
        animationStrings.Add("|");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            i++;

            if (i>= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}